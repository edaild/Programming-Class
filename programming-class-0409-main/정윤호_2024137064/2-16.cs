using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        bool one = 10 < 0;
        bool other = 20 > 100;

        Debug.Log(one);
        Debug.Log(other);
    }

}
