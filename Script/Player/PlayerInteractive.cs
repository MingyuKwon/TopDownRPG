using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public class PlayerInteractive : MonoBehaviour
{
    NPCDialogScript npc = null;
    private void OnTriggerEnter2D(Collider2D other) {
        npc =  other.gameObject.GetComponent<NPCDialogScript>();
    }

    void OnInteractive(InputValue value)
    {
        if(value.isPressed)
        {
            if(GameManager.instance.isPlayerNearNPC && npc != null)
            {
                npc.showDialog();

            }else
            {

            }
        }
        
    }
}
