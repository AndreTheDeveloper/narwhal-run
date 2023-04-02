using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController : MonoBehaviour
{
     public Animator animator;
     public string button;

    public void PlayAnimation()
    {
        animator.Play(button);
    }

}
