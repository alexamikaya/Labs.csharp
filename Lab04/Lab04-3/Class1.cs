using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04_1
{
    public class Test
    {
        static void Main()
        {
            int x;
            bool ok;
            int f;
            Console.WriteLine("Напишите число: ");
            x = int.Parse(Console.ReadLine());
            ok = Utils.Factorial(x, out f);
            if (ok)
                Console.WriteLine("Factorial (" + x + ") = " + f);
            else
                Console.WriteLine("Не могу высчитать факториал");
            Console.Read();
        }
    }
}
