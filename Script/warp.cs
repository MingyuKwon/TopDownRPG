using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class warp : MonoBehaviour
{
    [SerializeField] int sceneIndex;
    [SerializeField] WayPoint wayPoint;
    CameraSetting cameraSetting;

    void Awake() {
        cameraSetting = FindObjectOfType<CameraSetting>();
    }

    void OnTriggerEnter2D(Collider2D other) 
    {
        cameraSetting.gameObject.SetActive(false);
        blackOut.instance.BlackOut(sceneIndex);
        other.gameObject.transform.position = new Vector3(wayPoint.x, wayPoint.y, other.gameObject.transform.position.z);
    }   
}
