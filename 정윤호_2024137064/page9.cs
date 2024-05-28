using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class test : MonoBehaviour
{

    class Car
    {
        int carNuumber;
        int inTime;
        int outTime;

        public void SetInTime()
        {
            this.inTime = DateTime.Now.Hour;
        }
        public void SetOutTime()
        {
            this.outTime = DateTime.Now.Hour;
        }
    }
    void Start()
    {
       Car car = new Car();
        car.SetInTime();
        car.SetOutTime();
    }
}
