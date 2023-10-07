using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

namespace Biscuit.InGame
{
    public class InGameManager : MonoBehaviour
    {

        enum  Phase{
            Wait = 0,
            Listen,
            Play,
            End,
        }

        private bool _isPause = false;

        [SerializeField]
        private LaneController _laneController = null;

        private Phase _phase = Phase.Wait;

        // Start is called before the first frame update
        void Start()
        {
            QualitySettings.vSyncCount = 0;
            Application.targetFrameRate = 60;

            init();
        }

        private void init()
        {
            _phase = Phase.Wait;

            StartCoroutine(startListen());
        }

        // Update is called once per frame
        void Update()
        {
            // Debug.Log(string.Format("####{0}", Time.deltaTime));

            if (_isPause)
            {
                return;
            }

            if (null != _laneController)
            {
                _laneController.UpdateScene(Time.deltaTime);

                if(Phase.Listen == _phase)
                {
                    if (_laneController.IsFinished)
                    {
                        StartCoroutine(startPlay());
                    }
                }

                if (Phase.Play == _phase)
                {
                    if (_laneController.IsFinished)
                    {
                        _phase = Phase.End;
                        // TODO
                        StartCoroutine(startListen());
                    }
                }
            }

        }


        public IEnumerator startListen()
        {
            _phase = Phase.Listen;
            if (null != _laneController)
            {
                _laneController.Init();
            }

            yield return new WaitForSeconds(3.0f);

            if (null != _laneController)
            {
                _laneController.StartTime();
            }
        }


        public IEnumerator startPlay()
        {
            _phase = Phase.Play;
            if (null != _laneController)
            {
                _laneController.ResetTime();
            }

            yield return new WaitForSeconds(3.0f);

            if (null != _laneController)
            {
                _laneController.StartTime();
            }
        }



    }

}