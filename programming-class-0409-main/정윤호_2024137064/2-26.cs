using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // int �ڷ����� ���ڸ� �����մϴ�.
        int intNumber = 214743647;

        // int �ڷ����� long �ڷ������� �ڵ� ��ȯ �մϴ�.
        long intToLong = intNumber;
        Debug.Log(intToLong);
        
        // int �ڷ����� double �ڷ������� �ڵ� ��ȯ �մϴ�.
        double intToDouble = intNumber;
        Debug.Log(intToDouble);
    }

}
