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
        string input = "-52273";
        int number2 = int.Parse(input);

        Debug.Log(number2 > 0 ? "자연수입니다." : "자연수가 아닙니디.");
      
    }
 
 
}
