using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // ��ong �ڷ����� int �ڷ������� ��ȯ�˴ϴ�.
        long longNumber = 2147483647L + 2147483647L;
        int longtoInt = (int)longNumber;
        Debug.Log(longtoInt);


        // doble �ڷ����� int �ڷ������� ��ȯ�մϴ�.

        double doubleNumber = 52.273103332;
        int doubleToint = (int)doubleNumber;
        Debug.Log(doubleToint);

    }

}
