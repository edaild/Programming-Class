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
            Debug.Log("��ħ ���� �ð��Դϴ�.");
        }
        else
            if (DateTime.Now.Hour < 15)
        {
            Debug.Log("���� ���� �ð��Դϴ�.");
        }
        else
        {
            Debug.Log("���� ���� �ð��Դϴ�.");
        }
      
    }
 
 
}
