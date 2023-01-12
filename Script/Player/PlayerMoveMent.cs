using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public class PlayerMoveMent : MonoBehaviour
{
    [SerializeField] Vector2 inputValue;
    [SerializeField] float moveSpeed = 1;

    public bool moving = true;
    Rigidbody2D RB;
    CameraSetting refrenceCamera = null;

    Vector3 maxLimit;
    Vector3 minLimit;



    void Awake() {
        RB = GetComponent<Rigidbody2D>();
    }

    void Update() {
        if(refrenceCamera == null)
        {
            refrenceCamera = FindObjectOfType<CameraSetting>();
            maxLimit = refrenceCamera.maxLimit;
            minLimit = refrenceCamera.minLimit;
        }
        if(moving && !GameManager.instance.isPlayerPaused)
        {
            RB.velocity = inputValue * moveSpeed;

            if(this.transform.position.x >= maxLimit.x){this.transform.position = new Vector3(maxLimit.x,this.transform.position.y, this.transform.position.z );}
            if(this.transform.position.x <= minLimit.x){this.transform.position = new Vector3(minLimit.x,this.transform.position.y, this.transform.position.z );}
            if(this.transform.position.y >= maxLimit.y){this.transform.position = new Vector3(this.transform.position.x,maxLimit.y, this.transform.position.z ) ;}
            if(this.transform.position.y <= minLimit.y){this.transform.position = new Vector3(this.transform.position.x,minLimit.y, this.transform.position.z ) ;}
        }else
        {
            RB.velocity = new Vector2(0f,0f);
        }

    }

    void OnMove(InputValue value)
    {
        inputValue = value.Get<Vector2>();
    }
}
