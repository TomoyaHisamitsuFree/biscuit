using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

namespace Biscuit.Result
{
    public class ResultManager : MonoBehaviour
    {

        [SerializeField]
        private TextMeshProUGUI _scoreText = null;
        [SerializeField]
        private TextMeshProUGUI _perfectText = null;
        [SerializeField]
        private TextMeshProUGUI _goodText = null;
        [SerializeField]
        private TextMeshProUGUI _badText = null;


        private ResultData _resultData = null;

        // Start is called before the first frame update
        void Start()
        {
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

        }

        // Update is called once per frame
        void Update()
        {

        }
    }

}