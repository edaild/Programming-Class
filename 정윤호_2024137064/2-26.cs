using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // int 자료형의 숫자를 생성합니다.
        int intNumber = 214743647;

        // int 자료형을 long 자료형을로 자동 변환 합니다.
        long intToLong = intNumber;
        Debug.Log(intToLong);
        
        // int 자료형은 double 자료형으로 자동 변환 합니다.
        double intToDouble = intNumber;
        Debug.Log(intToDouble);
    }

}
