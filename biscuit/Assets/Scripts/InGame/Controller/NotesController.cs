using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Biscuit.InGame
{
    public class NotesController : MonoBehaviour
    {
        public enum Type
        {
            A = 0,
            S,
            D,
            F,
            AS,
            AD,
            AF,
            SD,
            SF,
            DF,

        }

        [SerializeField]
        private Type _type = Type.A;
        public Type NotesType => _type;

        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }
    }

}