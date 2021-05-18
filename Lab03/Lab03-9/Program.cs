using System;
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
            try
            {

                System.Console.Write("Введите год: ");
                string line = Console.ReadLine();
                int yearNum = int.Parse(line);
                bool isLeapYear = (yearNum % 4 == 0) && (yearNum % 100 != 0 || yearNum % 400 == 0);
                int maxDayNum = isLeapYear ? 366 : 365;
                if (isLeapYear)
                {
                    Console.WriteLine(" год високосный");
                }
                else
                {
                    Console.WriteLine(" год не високосный");
                }
                int[] DaysInMonths = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
                int[] DaysInLeapMonths = { 31, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
                System.Console.Write("Введите день года от 1 до {0}: ", maxDayNum);
                string day = Console.ReadLine();
                int dayNum = int.Parse(day);
                if (dayNum < 1 || dayNum > maxDayNum)
                {
                    throw new ArgumentOutOfRangeException("Day out of range");
                }
                int monthNum = 0;
                if (isLeapYear)
                {
                    foreach (int daysInMonth in DaysInLeapMonths)
                        if (dayNum <= daysInMonth)
                        {
                            break;
                        }
                        else
                        {
                            dayNum -= daysInMonth;
                            monthNum++;
                        }
                }
                else
                {
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
                }
                MonthName temp = (MonthName)monthNum;
                string monthName = temp.ToString();
                Console.WriteLine("{0} {1}", dayNum, monthName);
            }

            catch (Exception caught)
            {

                Console.WriteLine(caught);
            }
            Console.Read();
        }
    }
}