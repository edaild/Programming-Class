﻿using System;

class MainClass
{
    static void Main(string[] args)
    {
        while (true) { 
        Console.WriteLine("이번 달은 몇 월인가요 : ");
        int N = int.Parse(Console.ReadLine());
        switch (N)
        {
            case 12:
            case 1:
            case 2:
                Console.WriteLine("겨울입니다.");
                break;
            case 3:
            case 4:
            case 5:
                Console.WriteLine("봄입니다.");
                break;
            case 6:
            case 7:
            case 8:
                Console.WriteLine("여름입니다.");
                break;
            case 9:
            case 10:
            case 11:
                Console.WriteLine("여름입니다.");
                break;
                default:
                    Console.WriteLine("잘못 입력 하였습니다.");
                    break;
                break;
            }
           
        }
    }
}

