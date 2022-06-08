using System;

namespace Delegate
{
    //delegate (Type) bien = phuong thuc
    public delegate void ShowLog(string message);

    class Program
    {
        
        static void Info(string s)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(s);
            Console.ResetColor();
        }

        static void Warning(string s)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(s);
            Console.ResetColor();
        }

        //delegate int KIEU1();
        static int Tong(int a, int b) => a + b;
        static int Hieu(int a, int b) => a - b;

        static void Main(string[] args)
        {
            ShowLog log = null;

            //log = Info;

            //log = Warning;

            //// Tham chieu den nhieu method (chuoi tham chieu)
            //log += Info;
            //log += Info;
            //log += Info;
            //log += Warning;
            //log += Warning;

            //if (log != null)
            //{
            //    log("Tuan Anh dep trai");
            //}

            //log?.Invoke("Tuan Anh dep trai Invoke");


            // Action, Func : delegate - generic
            Action action; // ~ delegate void KIEU();
            Action<string, int> action1; // ~ delegate void KIEU(string s, int i);

            Action<string> action2; // ~ delegate void KIEU(string s);

            action2 = Warning;
            action2 += Info;

            action2?.Invoke("ABC Tuihoclaptrinh");

            Func<int> f1; // ~ delegate int KIEU();
            Func<string, double, string> f2; // ~ delegate string KIEU(string, double);

            Func<int, int ,int> f3;
            f3 = Tong;

            int a = 5, b = 4;
            Console.WriteLine($"Tong cua {a} + {b} = {f3(a, b)}");

            f3 = Hieu;
            Console.WriteLine($"Hieu cua {a} - {b} = {f3(a, b)}");

        }
    }
}
