using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Biscuit.InGame
{
    public class LaneController : MonoBehaviour
    {

        private float _time = 0.0f;

        private float _speed = 1.0f;

        [SerializeField]
        private float _maxTime = 16.0f;


        [SerializeField]
        private GameObject _timePos = null;



        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }


        public void Init()
        {
            _time = 0.0f;
        }


        public void UpdateScene(float timeDelta)
        {
            if (_maxTime == _time) return;
            _time += _speed * timeDelta;
            if(_maxTime < _time)
            {
                _time = _maxTime;
            }

            updatePos();
        }

        private void updatePos ()
        {
            if (null == _timePos) return;
            var pos = _timePos.transform.localPosition;
            pos.x = _time;
            _timePos.transform.localPosition = pos;
        }

    }



}
