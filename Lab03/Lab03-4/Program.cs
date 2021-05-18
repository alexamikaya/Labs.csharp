﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03
{
    enum MonthName

    {
        January,
        February,
        March,
        April,
        May,
        June,
        July,
        August,
        September,
        October,
        November,
        December
    }
    class WhatDay
    {
        static void Main(string[] args)
        {
            int[] DaysInMonths = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            System.Console.Write("Введите день года от 1 до 365: ");
            string line = Console.ReadLine();
            int dayNum = int.Parse(line);
            int monthNum = 0;
          
            foreach (int daysInMonth in DaysInMonths)
            if (dayNum <= daysInMonth)
            {
                break;
            }
            else
            {
                dayNum -= daysInMonth;
                monthNum++;
            }
            MonthName temp = (MonthName)monthNum;
            string monthName = temp.ToString();
            Console.WriteLine("{0} {1}", dayNum, monthName);
            Console.Read();
        }
    }
}