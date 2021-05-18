using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04_1
{
    public class Test
    {
        public static void Main()
        {
            int x;
            int y;
            int greater;
            Console.WriteLine("Напишите первое число: ");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine("Напишите второе число: ");
            y = int.Parse(Console.ReadLine());
            greater = Utils.Greater(x, y);
            Console.WriteLine("Значение greater равно " + greater);
            Console.WriteLine("Before swap: " + x + "," + y);
            Utils.Swap(ref x, ref y);
            Console.WriteLine("After swap: " + x + "," + y);
            Console.Read();
        }
    }
}
