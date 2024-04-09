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
        if (DateTime.Now.Hour < 12)
        {
            Debug.Log("오전입니다.");
        }
        else if(DateTime.Now.Hour > 12)
        {
            Debug.Log("오후입니다.");
        }

    }
 
 
}
