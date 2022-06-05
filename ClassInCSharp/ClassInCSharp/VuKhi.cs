using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassInCSharp
{
    // <Access Modifiers> class Class_Name {
    // attribute ..
    // constructor ..
    // method ..
    // }
    public class VuKhi
    {
        // Tên của Vũ Khí: Súng lục, Súng Trường, Dao ..
        public string name = "Tên Vũ Khí";

        // Độ sát thương 10 cấp độ 
        int doSatThuong = 0;

        // Constructor : Phương thức khởi tạo (được gọi khi toán tử new tạo đối tượng)
        // Tên constructor trùng với tên lớp, trường hợp này không tham số
        public VuKhi()
        {
            this.doSatThuong = 1;
        }

        // trường hợp này có tham số
        public VuKhi(string name, int dosatthuong)
        {
            this.name = name;
            SetDoSatThuong(dosatthuong);
        }

        // Hàm này thiết lập độ sát thương
        public void SetDoSatThuong(int mucdo)
        {
            this.doSatThuong = mucdo;
        }

        // In ra: Tên vu khí: * * * * * * * * (bằng độ sát thương)
        public void TanCong()
        {
            Console.Write(name + ": \t");
            for (int i = 0; i < doSatThuong; i++)
            {
                Console.Write(" * ");
            }
            Console.WriteLine();
        }

        public static int Sum(int a, int b)
        {
            return a + b;
        }

        public static double Sum(double a, double b)
        {
            return a + b;
        }
    }
}
