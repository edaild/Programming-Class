using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class NewBehaviourScript : MonoBehaviour
{
 
    void Start()
    {
        int inputNumber = 2022;

        if(inputNumber % 2 == 0)
        {
            Debug.Log("짝수입니다.");
        }
    }

   
}
