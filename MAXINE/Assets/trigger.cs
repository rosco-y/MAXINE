using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trigger : MonoBehaviour
{
        // Start is called before the first frame update
        public Animator _ani;

        private void OnTriggerEnter(Collider other)
        {
                _ani.SetInteger("condition", 2);
        }
}
