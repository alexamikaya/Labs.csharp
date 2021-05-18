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
            System.Console.Write("Введите день года от 1 до 365: ");
            string line = Console.ReadLine();
            int dayNum = int.Parse(line);
            int monthNum = 0;
            if (dayNum <= 31)
            {
                goto End;
            }
            else
            {
                dayNum -= 31;
                monthNum++;
            }
            if (dayNum <= 28)
            {
                goto End;
            }
            else
            {
                dayNum -= 28;
                monthNum++;
            }
            if (dayNum <= 31)
            {
                goto End;
            }
            else
            {
                dayNum -= 31;
                monthNum++;
            }
            if (dayNum <= 30)
            {
                goto End;
            }
            else
            {
                dayNum -= 30;
                monthNum++;
            }
            if (dayNum <= 31)
            {
                goto End;
            }
            else
            {
                dayNum -= 31;
                monthNum++;
            }
            if (dayNum <= 30)
            {
                goto End;
            }
            else
            {
                dayNum -= 30;
                monthNum++;
            }
            if (dayNum <= 31)
            {
                goto End;
            }
            else
            {
                dayNum -= 31;
                monthNum++;
            }
            if (dayNum <= 31)
            {
                goto End;
            }
            else
            {
                dayNum -= 31;
                monthNum++;
            }
            if (dayNum <= 30)
            {
                goto End;
            }
            else
            {
                dayNum -= 30;
                monthNum++;
            }
            if (dayNum <= 31)
            {
                goto End;
            }
            else
            {
                dayNum -= 31;
                monthNum++;
            }
            if (dayNum <= 30)
            {
                goto End;
            }
            else
            {
                dayNum -= 30;
                monthNum++;
            }
            if (dayNum <= 31)
            {
                goto End;
            }
            else
            {
                dayNum -= 31;
                monthNum++;
            }
        End:
            MonthName temp = (MonthName)monthNum;
            string monthName = temp.ToString();
            Console.WriteLine("{0} {1}", dayNum, monthName);
            Console.Read();
        }
    }
}