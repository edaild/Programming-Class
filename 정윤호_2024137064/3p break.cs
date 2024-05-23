using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class test : MonoBehaviour
{
    int sum = 0;
    void Start()
    {
        while (true)
        {
            sum += 10;
            Debug.Log(sum);
            if(sum % 100 == 0)
            {
                break;
            }

        }
    }
}
