using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string message = "�ȳ��ϼ���";

        Debug.Log(message + "!");
        Debug.Log(message[0]);
        Debug.Log(message[1]);
        Debug.Log(message[2]);

        Debug.Log("�ȳ��ϼ���"[0]);
        Debug.Log("�ȳ��ϼ���"[1]);
        Debug.Log("�ȳ��ϼ���"[2]);
    }

}
