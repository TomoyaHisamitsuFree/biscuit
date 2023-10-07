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
            B,
            C,
            D,
        }

        [SerializeField]
        private Type _type = Type.A;

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