using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(int.Parse("52").ToString());
        Debug.Log(long.Parse("273").ToString());
        Debug.Log(float.Parse("52.273").ToString());
        Debug.Log(double.Parse("103.32").ToString());

        Debug.Log(int.Parse("52").GetType().ToString());
        Debug.Log(long.Parse("273").GetType().ToString());
        Debug.Log(float.Parse("52.273").GetType().ToString());
        Debug.Log(double.Parse("103.32").GetType().ToString());
    }

}
