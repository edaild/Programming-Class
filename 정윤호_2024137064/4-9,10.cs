using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Data;
using UnityEditor.Experimental.GraphView;
using UnityEngine.Video;
public class NewBehaviourScript : MonoBehaviour
{
    void Start()
    {

        
        string[] array = {"���","��","����","����","�ٳ���"};
        // 4-9
        foreach (string item in array)
        {
            Debug.Log(item);
        }
        // 4-10
        foreach (var item in array)
        {
            Debug.Log(item);
        }
    }
}
       
 

