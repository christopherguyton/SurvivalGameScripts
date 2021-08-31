using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MoreMountains.CorgiEngine
{
    public class SoundModifier : MonoBehaviour
    {
       
        private Animator animator;
        void Start()
        {
            animator = gameObject.GetComponentInChildren<Animator>();
        }

        // Update is called once per frame
        void Update()
        {
            if (animator.GetNextAnimatorStateInfo(0).IsName("SkeletonOutlaw@Jump00") && Input.GetKeyDown(KeyCode.L)) {
                Debug.Log("Working");
            }
        }
    }

}
