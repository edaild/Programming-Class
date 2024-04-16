using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Data;
using UnityEditor.Experimental.GraphView;
public class NewBehaviourScript : MonoBehaviour
{
 
    void Start()
    {
        int[] intArray = { 52, 273, 32, 65, 103 };

        intArray[0] = 0;

        Debug.Log(intArray[0]);
        Debug.Log(intArray[1]);
        Debug.Log(intArray[2]);
        Debug.Log(intArray[3]);
        Debug.Log(intArray[4]);
    }
 
 
}
