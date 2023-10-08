using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using Biscuit.Result;

namespace Biscuit.InGame
{
    public class InGameManager : MonoBehaviour
    {
        enum  Phase{
            Wait = 0,
            Listen,
            Play,
            End,
            Pause,
        }

        private bool _isPause = false;

        [SerializeField]
        private LaneController _laneController = null;

        private Phase _phase = Phase.Wait;
        private Phase _postPhase = Phase.Wait;

        [SerializeField]
        private PauseManager _pauseManager = null;

        [SerializeField]
        private JudgeScript _judgeScript = null;

        private ResultData _resultData = null;

        [SerializeField]
        private int _maxWaveCount = 3;
        private int _waveCount = 0;

        // Start is called before the first frame update
        void Start()
        {
            QualitySettings.vSyncCount = 0;
            Application.targetFrameRate = 60;

            _resultData = ResultData.GetResultData();
            _resultData.ResetData();

            init();
        }

        private void init()
        {
            _phase = Phase.Wait;
            _waveCount = 0;

            StartCoroutine(startListen());
        }

        // Update is called once per frame
        void Update()
        {
            if (_isPause)
            {
                return;
            }

            // キー入力
            if (Input.GetKeyDown(KeyCode.P))
            {
                Puase();
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
                        if(null != _judgeScript)
                        {
                            _judgeScript.Delete();
                        }
                        // 最後のウェーブだった
                        if (_maxWaveCount == _waveCount)
                        {
                            goToResult();
                            _phase = Phase.End;
                        }
                        // 繰り返し
                        else
                        {
                            StartCoroutine(startListen());
                        }
                    }
                }
            }

        }


        public IEnumerator startListen()
        {
            _waveCount++;
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

        private void Puase()
        {
            if (null == _pauseManager) return;
            _postPhase = _phase;
            _phase = Phase.Pause;
            _pauseManager.gameObject.SetActive(true);
            _isPause = true;

            _pauseManager.BackEvenet = () => {
                _pauseManager.gameObject.SetActive(false);
                _phase = _postPhase;
                _isPause = false;
            };
        }


        private void goToResult()
        {
            // TODO
            _resultData.score = 123;
            _resultData.perfectCount = 456;
            _resultData.goodCount = 789;
            _resultData.badCount = 1011;

            // リザルトへ
            SceneManager.LoadScene("ResultScene");
        }

    }

}