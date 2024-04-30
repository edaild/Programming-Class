using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string message = "æ»≥Á«œººø‰";

        Debug.Log(message + "!");
        Debug.Log(message[0]);
        Debug.Log(message[1]);
        Debug.Log(message[2]);

        Debug.Log("æ»≥Á«œººø‰"[0]);
        Debug.Log("æ»≥Á«œººø‰"[1]);
        Debug.Log("æ»≥Á«œººø‰"[2]);
    }

}
