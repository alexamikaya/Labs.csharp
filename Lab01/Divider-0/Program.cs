using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Divider
{
    class DivideIt
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первое число");
            string temp = Console.ReadLine();
            int i = Int32.Parse(temp);

            Console.WriteLine("Введите второе число");
            temp = Console.ReadLine();
            int j = Int32.Parse(temp);
        }

    }
}