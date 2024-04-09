using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // ㅣong 자료형을 int 자료형으로 변환됩니다.
        long longNumber = 2147483647L + 2147483647L;
        int longtoInt = (int)longNumber;
        Debug.Log(longtoInt);


        // doble 자료형을 int 자료형으로 변환합니다.

        double doubleNumber = 52.273103332;
        int doubleToint = (int)doubleNumber;
        Debug.Log(doubleToint);

    }

}
