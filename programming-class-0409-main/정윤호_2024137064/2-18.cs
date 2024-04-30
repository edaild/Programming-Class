using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string Output = "hello";
        Output += "World";
        Output += "!!";
        Debug.Log(Output);
    }

}
