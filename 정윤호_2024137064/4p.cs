using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class test : MonoBehaviour
{
    void Start()
    {
        // 대소문자 화
        string input = "Potato Tomato";
        Debug.Log(input.ToUpper());
        Debug.Log(input.ToLower());

        // 문자열 자르기
        string input2 = "Potato Tomato";
        string[] inputs = input2.Split(new char[' ']);

        foreach (var item in inputs)
        {
            Debug.Log(item);
        }

        // 문자열 옆의 공백 제거
        string input3 = "Potato  Wn ";
        Debug.Log("::"+input3.Trim()+";;");

        // 배열의 문자열로
        string[] array = { "감자", "고구마", "토마토", "가지" };
        Debug.Log(string.Join(" ", array));
    }
}
