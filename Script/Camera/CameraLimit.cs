using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "cameraLimit", menuName ="Create CameraLimit ScriptObject/CameraLimit")]
public class CameraLimit : ScriptableObject
{
    public float XlimitMin = 0;
    public float XlimitMax = 0;
   
    public float YlimitMin = 0;
    public float YlimitMax = 0;
}
