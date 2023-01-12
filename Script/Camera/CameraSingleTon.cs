using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSingleTon : MonoBehaviour
{
    private void Awake() {
        int numGameSession = FindObjectsOfType<CameraSingleTon>().Length;
        if(numGameSession > 1)
        {
            Destroy(this.gameObject);
        }else
        {
            DontDestroyOnLoad(this.gameObject);
        }
    }


}
