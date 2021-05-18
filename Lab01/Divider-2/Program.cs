using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Divider
{
    class DivideIt
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Введите первое число");
                string temp = Console.ReadLine();
                int i = Int32.Parse(temp);

                Console.WriteLine("Введите второе число");
                temp = Console.ReadLine();
                int j = Int32.Parse(temp);
                int k = i / j;
                Console.WriteLine(k);
            }
            catch (Exception e)
            {
                Console.WriteLine("An exception was thrown: {0}", e);
            }
            Console.Read();
        }
    }
}
