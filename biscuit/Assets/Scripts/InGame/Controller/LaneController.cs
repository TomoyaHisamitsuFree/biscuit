using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.PlayerSettings;

namespace Biscuit.InGame
{
    public class LaneController : MonoBehaviour
    {

        private float _time = 0.0f;

        [SerializeField]
        private float _speed = 1.0f;

        [SerializeField]
        private float _maxTime = 16.5f;


        [SerializeField]
        private GameObject _timePos = null;



        private bool _isStarted = false;
        public bool IsStarted => _isStarted;

        private bool _isFinished = false;
        public bool IsFinished => _isFinished;

        [SerializeField]
        private List<GameObject> _notesPosBaseList = new List<GameObject>();

        [SerializeField]
        private List<GameObject> _notesPrefabList = new List<GameObject>();


        [SerializeField]
        private int _notesCount = 4;

        private List<GameObject> _notesList = new List<GameObject>();

        private List<Vector3> _notesPosList = new List<Vector3>();


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
            _isStarted = false;

            ResetTime();

            createNotes();
        }

        public void ResetTime()
        {
            _time = 0.0f;
            _isFinished = false;

            _isStarted = false;
        }

        public void StartTime()
        {
            _isStarted = true;
        }
        


        public void UpdateScene(float timeDelta)
        {
            if (!IsStarted) return;
            if (IsFinished) return;
            _time += _speed * timeDelta;
            if(_maxTime <= _time)
            {
                _time = _maxTime;
                _isFinished = true;
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


        private void createNotes()
        {
            destroyNotes();
            resetNotesPosList();

            for (int i = 0; i < _notesCount; i++)
            {
                createSingleNotes();
            }

        }

        private void createSingleNotes()
        {
            var prefab = _notesPrefabList[Random.Range(0, _notesPrefabList.Count)];
            if (null == prefab) return;
            var notes = Instantiate(prefab);

            notes.transform.position = getNotesPos(NotesController.Type.A); // TODO

            _notesList.Add(notes);
        }


        private void destroyNotes()
        {
            foreach(var notes in _notesList)
            {
                if (null == notes) continue;
                GameObject.Destroy(notes);
            }

            _notesList.Clear();
        }

        private void resetNotesPosList()
        {
            _notesPosList.Clear();

            for (int i = 0; i < _notesPosBaseList.Count; i++)
            {
                var pos = _notesPosBaseList[i];
                _notesPosList.Add(pos.transform.position);

                // TODO
                // 次のノード位置は通常は使わないためスキップ
                i++;
            }
        }

        private Vector3 getNotesPos(NotesController.Type type)
        {
            if (0 == _notesPosList.Count) return Vector3.zero;
            var index = Random.Range(0, _notesPosList.Count);

            var pos = _notesPosList[index];

            _notesPosList.RemoveAt(index);

            return pos;
        }

    }



}
