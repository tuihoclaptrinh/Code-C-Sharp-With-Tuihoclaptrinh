using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extension
{
    public static class Mylib
    {
        public static double BinhPhuong(this double x) => x * x;
        public static double Canbac2(this double x) => Math.Sqrt(x);
        public static double Sin(this double x) => Math.Sin(x);
        public static double Cos(this double x) => Math.Cos(x);


    }
}
