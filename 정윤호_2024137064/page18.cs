using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class test : MonoBehaviour
{
     void Start()
    {
        Debug.Log(Mathf.Abs(-52273));
        Debug.Log(Mathf.Ceil(52.273f));
        Debug.Log(Mathf.Floor(-52.273f));
        Debug.Log(Mathf.Max(52, 273));
        Debug.Log(Mathf.Min(52, 273));
        Debug.Log(Mathf.Round(52.273f));
    }


}
