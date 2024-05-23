using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{

    void Start()
    {
        for (int j = 1; j < 10; j++)
        {
            if(j % 2 == 1)
            {
                Debug.Log(j);
            }
        }
    }
}
