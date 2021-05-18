using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04_1
{
    class Utils
    {
        public static int Greater(int a, int b)
        {
            if (a > b)
                return a;
            else
                return b;
        }
            public static void Swap(ref int a, ref int b)
            {
                int temp = a;
                a = b;
                b = temp;
            }
    }
}
