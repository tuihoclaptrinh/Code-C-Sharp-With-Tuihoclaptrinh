using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Fuction
{
    class Calculator
    {
        public static void Tong(int a, int b)
        {
            Console.WriteLine($"Tổng {a} + {b} = {a+b}");
        }

        public static void Tong(double a, double b)
        {
            Console.WriteLine($"Tổng {a} + {b} = {a + b}");
        }
    }
}
