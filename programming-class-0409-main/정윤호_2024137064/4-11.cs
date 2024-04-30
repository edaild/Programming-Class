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
        string stars;
        for (int n= 0; n < 10; n++)
        {
            stars = "";
            for(int o = 0; o < n +1; o++)
            {
                stars += "*";
            }
            Debug.Log(stars);
        }
    }
}
       
 

