using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Data;
using UnityEditor.Experimental.GraphView;
using UnityEngine.Video;
public class NewBehaviourScript : MonoBehaviour
{
    int output = 0;
    void Start()
    {
        for (int L = 0; L <= 100; L++)
        {
            output += L;
        }
        Debug.Log(output);
    }
}
 

