using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class test : MonoBehaviour
{
     void Start()
    {   
        // 리스트 변수 선언
        List<int> list = new List<int>();

        // 리스트에 요소 추가
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
