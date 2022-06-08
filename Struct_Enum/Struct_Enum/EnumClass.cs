using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struct_Enum
{
    class EnumClass
    {
        //Kiểu liệt kê (enum) khai báo một tập hợp các hằng số có tên, mặc định giá trị các hằng số này là
        //kiểu int và bắt đầu từ 0 trở đi trong khai báo kiểu liệt kê.
        //Liệt kê (enum) thuộc dạng kiểu giá trị như struct. Để khai báo một kiểu liệt kê thì dùng từ khóa enum

        enum HocLuc { Kem, TrungBinh, Kha, Gioi };
        enum HocLuc2 { Kem, TrungBinh = 5, Kha, Gioi };
    }
}
