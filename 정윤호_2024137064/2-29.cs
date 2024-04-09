using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        double number = 52.273103;
        Debug.Log(number.ToString("0.0"));
        Debug.Log(number.ToString("0.00"));
        Debug.Log(number.ToString("0.000"));
        Debug.Log(number.ToString("0.0000"));
    }

}
