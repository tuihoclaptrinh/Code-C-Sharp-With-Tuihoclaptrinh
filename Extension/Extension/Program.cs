using System;
using static Extension.Mylib;

namespace Extension
{

     static class Program
    {
        public static void Print(this string s, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(s);
            Console.ResetColor();
        }
        static void Main(string[] args)
        {
            "Tuan Anh Dep Trai".Print(ConsoleColor.Red);

            double x = 5;

            Console.WriteLine(x.BinhPhuong());
            Console.WriteLine(x.Canbac2());
            Console.WriteLine(x.Cos());
            Console.WriteLine(x.Sin());
        }
    }
}
