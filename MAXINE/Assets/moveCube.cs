using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveCube : MonoBehaviour
{
        Rigidbody _rig;
        public float _speed = 15f;
        // Start is called before the first frame update
        void Start()
        {
                _rig = GetComponent<Rigidbody>();

        }

        // Update is called once per frame
        void Update()
        {
                _rig.velocity = new Vector3(0, 0, _speed);

        }
}
