﻿using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.VitovskayaAN.Sprint1.Task5.V4.Lib
{
    public class DataService : ISprint1Task5V4
    {
        public int SecondsToHours(int k)
        {
            return k / 60 / 60;
        }
    }
}
