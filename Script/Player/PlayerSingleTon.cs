using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSingleTon : MonoBehaviour
{
    static PlayerSingleTon instance = null;
    
    void Awake() {
        
        if(instance == null)
        {
            instance = this;

            DontDestroyOnLoad(this.gameObject);
        }else
        {
            Destroy(this.gameObject);
        }
    }

    public static PlayerSingleTon GetInstance()
    {
        return instance;
    }
}
