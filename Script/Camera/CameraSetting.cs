using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class CameraSetting : MonoBehaviour
{
    [SerializeField] Tilemap tilemap;
    Transform pm; 
    public Vector3 maxLimit;
    public Vector3 minLimit;

    float cameraVerticalHalf;
    float cameraHorizontalHalf;

    void Start() {
        pm = PlayerSingleTon.GetInstance().transform;
        //maxLimit = new Vector3(tilemap.localBounds.max.x-0.5f, tilemap.localBounds.max.y-0.5f, tilemap.localBounds.max.z) ;
        //minLimit = new Vector3(tilemap.localBounds.min.x + 0.5f, tilemap.localBounds.min.y + 0.5f , tilemap.localBounds.max.z) ;

        maxLimit = tilemap.localBounds.max;
        minLimit = tilemap.localBounds.min;
        cameraVerticalHalf = Camera.main.orthographicSize;
        cameraHorizontalHalf = Camera.main.aspect * cameraVerticalHalf;
    }

    void Update(){
            Vector3 pmPosition = pm.position;
            float clampXPosition = Mathf.Clamp(pmPosition.x , minLimit.x + cameraHorizontalHalf, maxLimit.x-cameraHorizontalHalf);
            float clampYPosition = Mathf.Clamp(pmPosition.y , minLimit.y + cameraVerticalHalf, maxLimit.y - cameraVerticalHalf);
            transform.position = new Vector3(clampXPosition, clampYPosition, -10);
    }
}
