using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

namespace Biscuit.Result
{
    public class ResultManager : MonoBehaviour
    {
        public bool FallBis;
        public GameObject Biscuit;
        public GameObject Yama;
        public Vector3 pos;
        private int nCnt;

        [SerializeField]
        private TextMeshProUGUI _scoreText = null;
        [SerializeField]
        private TextMeshProUGUI _perfectText = null;
        [SerializeField]
        private TextMeshProUGUI _goodText = null;
        [SerializeField]
        private TextMeshProUGUI _badText = null;


        private ResultData _resultData = null;

        //======================================
        //  èâä˙âªèàóù
        //======================================
        void Start()
        {
            QualitySettings.vSyncCount = 0;
            Application.targetFrameRate = 60;

            _resultData = ResultData.GetResultData();
            if(null != _scoreText)
            {
                _scoreText.text = string.Format("score:{0}", _resultData.score);
            }
            if (null != _perfectText)
            {
                _perfectText.text = string.Format("score:{0}", _resultData.perfectCount);
            }
            if (null != _goodText)
            {
                _goodText.text = string.Format("score:{0}", _resultData.goodCount);
            }
            if (null != _badText)
            {
                _badText.text = string.Format("score:{0}", _resultData.badCount);
            }
            nCnt = 0;
            FallBis = true;

        }

        //======================================
        //  çXêVèàóù
        //======================================
        void Update()
        {
            if(FallBis == true)
            {
                int nRand = Random.Range(-3, 3);
                nCnt++;

                if (nCnt % 5 == 0)
                {
                    Instantiate(Biscuit, new Vector3(nRand, 5, 0), Quaternion.identity);
                }
            }

        }
    }

}