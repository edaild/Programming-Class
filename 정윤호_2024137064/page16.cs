using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class test : MonoBehaviour
{
     void Start()
    {   
        // ����Ʈ ���� ����
        List<int> list = new List<int>();

        // ����Ʈ�� ��� �߰�
        list.Add(52);
        list.Add(273);
        list.Add(32);
        list.Add(64);

        foreach ( var item in list)
        {
            Debug.Log("Count :"+list.Count + "\titem : " + item);
        }

        list.Remove(52);

        foreach (var item in list)
        {
            Debug.Log("Count :" + list.Count + "\titem : " + item);
        }
    }


}
