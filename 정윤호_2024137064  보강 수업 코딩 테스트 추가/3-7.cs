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
        int inputNumber = 2021;
        
        switch (inputNumber % 2)
        {
            case 0:
                Debug.Log("¦�� �Դϴ�.");
                break;
            case 1:
                Debug.Log("Ȧ�� �Դϴ�.");
                break;
        }
      
    }
 
 
}
