using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // ���� �ڷ��� ��ȯ�� ���� ������ �ս� ��
        long longNumber = 2147483647L + 2147483647L;
        int intNumber = (int)longNumber;
        Debug.Log(intNumber);


        // ���� �ڷ��� ��ȯ�� ���� ������ �ս� �߻����� ���� ��

        long longNumber2 = 52273;
        int intNumber2 = (int)longNumber2;
        Debug.Log(intNumber2);

    }

}
