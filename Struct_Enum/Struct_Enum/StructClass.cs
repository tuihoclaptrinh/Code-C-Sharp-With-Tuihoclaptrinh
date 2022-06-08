using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struct_Enum
{
    struct StructClass
    {
        //struct kiểu dữ liệu cấu trúc(còn gọi là structure) - kiểu dữ liệu này tạo thành
        //khi ta muốn gộp các dữ liệu có liên quan thành một nhóm(đóng gói dữ liệu).
        //Để tạo ra kiểu dữ liệu cấu trúc dùng đến từ khóa struct với khai báo khá giống khai báo lớp,
        //tuy nhiên struct là thuộc nhóm kiểu giá trị C# chứ không phải kiểu tham chiếu C#
        //(Do đó, truyền tham số dùng struct là tham trị: xem thêm tham chiếu, tham trị C# ).
        //Trong struct có thể chứa: trường dữ liệu, thuộc tính, phương thức khởi tạo, hằng số, các phương thức, toán tử, sự kiện.

        public string name;   // trường tên sản phẩm
        public decimal price; // trường giá sản phẩm

        // Phương thức sinh ra chuỗi thông tin
        public override string ToString() => $"{name} : {price}";

    }
}
