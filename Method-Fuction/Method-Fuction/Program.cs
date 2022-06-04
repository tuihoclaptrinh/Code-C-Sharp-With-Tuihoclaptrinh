using System;
using System.Text;

namespace Method_Fuction
{
    static class Program
    {
        // <Access Modifier> <return type> <name_method>(<parameters>)
        // {
        //    Statements
        // };

        public static int Tich(this int a, int b) => a * b;

        // Phương thức XinChao()
        static void XinChao() => Console.WriteLine("Hello I'm Tuihoclaptrinh");
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode; 
            int a = 1, b = 2;
            double c = 3.5, d = 5.5;

            XinChao();
            Console.WriteLine(a.Tich(4));

            // Gọi method từ class
            Calculator.Tong(a, b);

            // Overload method
            Calculator.Tong(c, d);

        }
    }
}
