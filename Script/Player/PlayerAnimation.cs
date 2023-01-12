using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{
    Rigidbody2D parentRB;
    Animator animator;

    void Awake(){
        parentRB = GetComponentInParent<Rigidbody2D>();
    }

    void Start() {
        animator = GetComponent<Animator>();
    }

    void Update() {
        animator.SetFloat("Xinput", parentRB.velocity.x);
        animator.SetFloat("Yinput", parentRB.velocity.y);

        if(parentRB.velocity.x > 0 || parentRB.velocity.x < 0)
        {
            animator.SetFloat("LastXinput", parentRB.velocity.x);
            animator.SetFloat("LastYinput", 0);
        }
        if(parentRB.velocity.y > 0 || parentRB.velocity.y < 0)
        {
            animator.SetFloat("LastXinput", 0);
            animator.SetFloat("LastYinput", parentRB.velocity.y);
        }
    }

    public void EndAttackAnimationEvent()
    {
        animator.SetBool("Attacking", false);
        GameManager.instance.ActivatePlayerMove();
    }


}
