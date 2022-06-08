using System;
using System.Linq;

namespace Lamda
{

    /*
     Lamda - Anonymous function

    1/ 
    (tham_so) => bieuthuc;

    2/
    (tham_so) => {
        cacbieuthuc;
        return bieu_thuc_tra_ve;
    }

     */
    class Program
    {
        static void Main(string[] args)
        {
            Action<string> thongbao;
            thongbao = (string s) => Console.WriteLine(s); // ~ delegate void KIEU(string s) = Action<string>

            thongbao?.Invoke("Hello Tuihoclaptrinh");

            Func<int, int, int> f1;

            f1 = (int a, int b) =>
            {
                int kq = a + b;
                return kq;
            };

            Console.WriteLine(f1(3, 4));

            int[] mang = { 2, 4, 5, 64, 33, 7, 8, 9, 55 };

            var kq = mang.Select(
                (int x) =>
                {
                    return Math.Sqrt(x);
                }
                );

            foreach (var item in kq)
            {
                Console.WriteLine(item);
            }

            mang.ToList().ForEach(
                
                (int x) =>
                {
                    if (x % 2 == 0)
                    {
                        Console.WriteLine("--------------------------------------------");

                        Console.WriteLine(x);
                    }
                }
            );

        }

    }

}
