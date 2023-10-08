using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

namespace Biscuit.Result
{
    public class ResultData : MonoBehaviour
    {
        private static readonly string OBJ_NAME = "ResultData";

        public int score = 0;
        public int badCount = 0;
        public int goodCount = 0;
        public int perfectCount = 0;

        // Start is called before the first frame update
        void Start()
        {
            gameObject.name = OBJ_NAME;
            DontDestroyOnLoad(this);
        }

        public static ResultData GetResultData()
        {
            var obj = GameObject.Find(OBJ_NAME);
            if (null == obj)
            {
                obj = new GameObject(OBJ_NAME);
            }
            var data = obj.GetOrAddComponent<ResultData>();
            return data;
        }


        public void ResetData()
        {
            score = 0;
            badCount = 0;
            goodCount = 0;
            perfectCount = 0;
        }

    }

}