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
        if (DateTime.Now.Hour < 11)
        {
            Debug.Log("아침 먹을 시간입니다.");
        }
        else
            if (DateTime.Now.Hour < 15)
        {
            Debug.Log("점심 먹을 시간입니다.");
        }
        else
        {
            Debug.Log("저녁 먹을 시간입니다.");
        }
      
    }
 
 
}
