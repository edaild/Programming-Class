using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class test : MonoBehaviour
{
    void Start()
    {
        // ��ҹ��� ȭ
        string input = "Potato Tomato";
        Debug.Log(input.ToUpper());
        Debug.Log(input.ToLower());

        // ���ڿ� �ڸ���
        string input2 = "Potato Tomato";
        string[] inputs = input2.Split(new char[' ']);

        foreach (var item in inputs)
        {
            Debug.Log(item);
        }

        // ���ڿ� ���� ���� ����
        string input3 = "Potato  Wn ";
        Debug.Log("::"+input3.Trim()+";;");

        // �迭�� ���ڿ���
        string[] array = { "����", "����", "�丶��", "����" };
        Debug.Log(string.Join(" ", array));
    }
}
