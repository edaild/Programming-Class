using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlTypes;
using Unity.VisualScripting;
using UnityEngine;

public class test : MonoBehaviour
{
    private void Start()
    {
        System.Random rand = new System.Random();

        Debug.Log(rand.NextDouble() * 10);
        Debug.Log(rand.NextDouble() * 10);
        Debug.Log(rand.NextDouble() * 10);
        Debug.Log(rand.NextDouble() * 10);
        Debug.Log(rand.NextDouble() * 10);
    }

  
}
