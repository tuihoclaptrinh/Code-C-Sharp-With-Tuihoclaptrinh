using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anonymous_Dynamic
{
    class Dynamic
    {
        //Biến kiểu động - ngầm định - khai báo với từ khóa dynamic,
        //thì kiểu thực sự của biến đó được xác định bằng đối tượng gán vào ở thời điểm chạy
        //(khác với kiểu ngầm định var kiểu xác định ngay thời điểm biên dịch)
        static void TestFunc(dynamic dvar)
        {
            Console.WriteLine(dvar.age); // ở thời điểm biên dịch - không biết dvar có thuộc tính age hay không, nhưng nó vẫn biên dịch
        }

        //var myProfile = new
        //{
        //    name = "XuanThuLab",
        //    age = 20,
        //    skill = "ABC"
        //};
        //TestFunc(myProfile); // In ra 20

    }
}
