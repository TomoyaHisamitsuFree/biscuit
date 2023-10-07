using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Biscuit.InGame
{
    public class InGameManager : MonoBehaviour
    {

        private bool _isPause = false;

        [SerializeField]
        private LaneController _laneController = null;

        // Start is called before the first frame update
        void Start()
        {
            QualitySettings.vSyncCount = 0;
            Application.targetFrameRate = 60;
        }

        // Update is called once per frame
        void Update()
        {
            // Debug.Log(string.Format("####{0}", Time.deltaTime));

            if (_isPause)
            {
                return;
            }

            if(null != _laneController)
            {
                _laneController.UpdateScene(Time.deltaTime);

            }

        }



    }

}