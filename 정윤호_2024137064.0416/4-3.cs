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
        int j = 0;
        int[] intArray3 = { 52, 273, 32, 65, 103 };

        while (j < intArray3.Length)
        {
            Debug.Log(j + "번째 출력 :" + intArray3[j]);
            j++;
        }
    }
 
 
}
