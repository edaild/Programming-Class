using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // 강제 자료형 변환에 따른 데이터 손실 예
        long longNumber = 2147483647L + 2147483647L;
        int intNumber = (int)longNumber;
        Debug.Log(intNumber);


        // 강제 자료형 변환에 따른 데이터 손실 발생하지 않은 예

        long longNumber2 = 52273;
        int intNumber2 = (int)longNumber2;
        Debug.Log(intNumber2);

    }

}
