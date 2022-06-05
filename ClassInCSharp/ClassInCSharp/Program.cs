using System;
using System.Text;

namespace ClassInCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            // Tạo và sử dụng đối tượng class
            // Khai báo và khởi tạo đối tượng luôn
            //var ob1 = new ClassName();

            // Khai báo, sau đó khởi tạo
            //ClassName ob2;
            //ob2 = new ClassName();

            var sungluc = new VuKhi();              // Khai báo và khởi tạo
            sungluc.name = "SÚNG LỤC";              // Truy cập và gán thuộc tính
            sungluc.SetDoSatThuong(5);             // Truy cập (gọi) phương thức

            VuKhi sungtruong = new VuKhi();
            sungtruong.name = "SÚNG TRƯỜNG";
            sungtruong.SetDoSatThuong(20);

            sungluc.TanCong();                      // Gọi phương thức
            sungtruong.TanCong();                   // Gọi phương thức

            // Khởi tạo đối tượng, hàm tạo VuKhi(name, dosatthuong) được gọi
            VuKhi sungtruong2 = new VuKhi(name: "SÚNG TRƯỜNG", dosatthuong: 20);

            // (Overloading) Method phương thức
            // Tính đa hình (polymorphism) là cách ứng xử của đối tượng - ứng xử này là khác nhau tùy thuộc vào tình huống cụ thể.

            double a = 1;
            double b = 2;
            var c = VuKhi.Sum(a, b); // c = 3 có kiểu double

            int a1 = 1;
            int b1 = 2;
            var c1 = VuKhi.Sum(a1, b1); // c = 3 nhưng có kiểu int

            // Tìm hiểu tính đóng gói lập trình hướng đối tượng
            //public thành viên có thể truy cập được bởi code bât kỳ đâu, ngoài đối tượng, không có hạn chế truy cập nào.
            //private phương thức, thuộc tính, trường khai báo với private chỉ có thể truy cập, gọi bởi các dòng code cùng lớp.
            //protected phương thức, thuộc tính, trường chỉ có thể truy cập, gọi bởi các dòng code cùng lớp hoặc các lớp kế thừa nó.
            //internal truy cập được bởi code ở cùng assembly(file).
            //protected internal truy cập được từ code assembly, hoặc lớp kế thừa nó ở assembly khác.
            //private protected truy cập được code khi cùng assembly trong cùng lớp, hoặc các lớp kế thừa nó.
        }
}
}
