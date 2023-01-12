using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerAttack : MonoBehaviour
{
    Rigidbody2D parentRB;
    Animator animator;

    void Awake(){
        parentRB = GetComponent<Rigidbody2D>();
    }

    void Start() {
        animator = GetComponentInChildren<Animator>();
    }
    void OnAttack(InputValue value)
    {
        if(!GameManager.instance.isPlayerPaused)
        {   
            GameManager.instance.InActivatePlayerMove();
            animator.SetBool("Attacking", true);
        }
    }

}
