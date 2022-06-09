using System;

namespace ExceptionClass
{
    class Program
    {
        public static double Thuong(double x, double y)
        {
            if (y == 0)
            {
                // Khởi tạo ngoại lệ, tham số là thông báo lỗi
                Exception myexception = new Exception("Số chia không được bằng 0");

                // phát sinh ngoại lệ, code phía sau throw không được thực thi
                throw myexception;
            }
            return x / y;
        }

        public static void UserInput(string s)
        {
            if (s.Length > 10)
            {
                Exception e = new DataTooLongExeption();
                throw e;    // lỗi văng ra
            }
            //Other code - no exeption
        }

        static void Main(string[] args)
        {
            int a = 5;
            int b = 0;
            try
            {
                var c = a / b;
                Console.WriteLine(c);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
                Console.WriteLine(e.ToString());
                Console.WriteLine(e.Data);
                Console.WriteLine(e.GetType().Name);
                Console.WriteLine("phep chia co loi");
            }
            Console.WriteLine("ket Thuc");

            try
            {
                int x = 10;
                int y = 0;
                int z = x / y;

            }
            catch (DivideByZeroException e1)
            {
                Console.WriteLine(e1.Message);
            }
            catch (Exception e2)
            {
                Console.WriteLine(e2.Message);
            }

            try
            {
                UserInput("Đây là một chuỗi rất dài ...");
            }
            catch (DataTooLongExeption e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception otherExeption)
            {
                Console.WriteLine(otherExeption.Message);
            }
        }
    }
}
