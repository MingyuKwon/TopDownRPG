using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SingleTonGenerator : MonoBehaviour
{
    [SerializeField] GameObject player;
    [SerializeField] GameObject blackoutUI;
    [SerializeField] GameObject standardUI;
    [SerializeField] GameObject gameManager;
    [SerializeField] GameObject playerStatus;

    void Awake() {
        int count = FindObjectsOfType<PlayerSingleTon>().Length;
        if(count < 1)
        {
            Instantiate(player);
        }

        count = FindObjectsOfType<blackOut>().Length;
        if(count < 1)
        {
            Instantiate(blackoutUI);
        }

        count = FindObjectsOfType<StandardUI>().Length;
        if(count < 1)
        {
            Instantiate(standardUI);
        }

        count = FindObjectsOfType<GameManager>().Length;
        if(count < 1)
        {
            Instantiate(gameManager);
        }

        count = FindObjectsOfType<PlayerStatus>().Length;
        if(count < 1)
        {
            Instantiate(playerStatus);
        }
    }


}
