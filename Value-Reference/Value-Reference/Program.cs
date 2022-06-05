using System;

namespace Value_Reference
{
    class Program
    {
        //  Kiểu giá trị và kiểu tham chiếu là hai nhóm chính phân loại kiểu dữ liệu của C#.
        //  Một biến kiểu giá trị thì biến đó sẽ lưu giá trị của đối tượng lưu trữ,
        //  khác với kiểu tham chiếu biến chứa địa chỉ trỏ đến nơi lưu đối tượng thực.
        //  Kiểu giá trị mặc định trong các phép toán gán, truyền tham số phương thức,
        //  kể cả trả về từ hàm - thì giá trị được sao chép.

        //Khi biến thuộc các kiểu sau, mặc định nó ứng xử là kiểu giá trị:
        //Các kiểu số nguyên như int, byte, long ...
        //Các kiểu số thực như float, double, decimal
        //Kiểu bool, kiểu char
        //Kiểu cấu trúc struct
        //Kiểu liệt kê enum
        //Kiểu Tuple

        public static void valuetypeExample()
        {
            // biến a, kiểu int là kiểu giá trị, nó lưu giá trị 100
            int a = 100;

            // kiểu giá trị khi gán, giá trị được copy
            int b = a;
            Console.WriteLine($"a = {a}, b = {b}");

            // b gán giá trị mới, a không thay đổi - vì chúng không cùng tham
            // chiếu đến 1 đối tượng chung, mà mỗi biến lưu một giá trị
            b = 200;
            Console.WriteLine($"a = {a}, b = {b}");

            // a = 100, b = 100
            // a = 100, b = 200
        }

        //Các biến kiểu tham chiếu nó chứa tham chiếu(địa chỉ nhớ) trỏ đến dữ liệu(là đối tượng),
        //với kiểu tham chiếu hai biến, hay nhiều biến có tên khác nhau có thể cùng trỏ đến cùng mội đối tượng,
        //khi đó dùng biến biến nào truy cập, tác động vào đối tượng đều mang lại kết quả như nhau.

        //Như vậy khi dùng kiểu tham chiếu, truyền dữ liệu trong hàm hay các phép gán
        //thì không phải là copy đối tượng hay giá trí mà chỉ là truyền tham chiếu(địa chỉ nhớ).

        //Những biển có kiểu sau thì nó là kiểu tham chiếu:
        //Biến kiểu lớp(class), các lớp thư viện hoặc lớp do bạn định nghĩa
        //Biến kiểu delegate
        //Biến kiểu interface, các giao diện từ thư viện hoặc tự định nghĩa
        //Biến kiểu dynamic
        //Biến kiểu object
        //Biến kiểu string

        class Stutent
        {
            public string Name;
            public Stutent(string name)
            {
                this.Name = name;
            }
        }


        // Ví dụ tham chiếu với biến kiểu giá trị:
        public static void ThamSoThamChieu(ref int x)
        {
            x = x * x;
            Console.WriteLine(x);
        }

        // Tham chiếu với out
        public static void OutExample(out int x)
        {
            x = 100;
        }

        static void Main(string[] args)
        {
            // 1.  Kiểu dữ liệu giá trị(value):
            // Một biến khi khai báo kiểu dữ liệu giá trị thì vùng nhớ của biến đó sẽ chứa giá trị của dữ liệu
            // và được lưu trữ trong bộ nhớ Stack.
            // Một số kiểu dữ liệu thuộc kiểu giá trị: bool, byte, char, decimal, double, enum, float, int, long,
            // sbyte, short, struct, uint, ulong, ushort.

            // 2. Kiểu dữ liệu tham chiếu (reference):
            // Một biến khi khai báo kiểu dữ liệu tham chiếu thì vùng nhớ của biến đó chỉ chứa địa chỉ của đối tượng dữ liệu
            // và lưu trong bộ nhớ Stack.
            // Đối tượng dữ liệu thực sự được lưu trong bộ nhớ Heap.


            //                         STACK                                             HEAP
            //            ---------------------------------               ---------------------------------
            //            -                               -               -                               -
            //            -          ----------           -               -              0xccc            -
            //        ----------------   10   -           -               -           -----------         -
            //        -   -          ----------           -               -           -  Kteam  -         -
            //        -   -                               -               -           -----------         -
            //        -   -                               -               -                   -           -
            //        -   -                               -               -                   -           -
            //        -   -          -----------          -               -    Tham Chiếu     -           -
            //        -   -          -  0xccc  ------------------------------------------------           -
            //        -   -          -----------          -               -                               -
            //        -   -               -               -               -                               -
            //        -   -               -               -               -                               -
            //        -   ---------------------------------               ---------------------------------
            //        -                   -
            //        -                   ------------------------
            //        --------                                   -
            //               -                                   -
            //               -                                   -
            //           int a = 10;                             -
            //          string b = "Kteam";                      -
            //                 -                                 -
            //                 -----------------------------------
            //
            //

            // 3. Truyền tham số kiểu giá trị với dạng tham chiếu trong C#

            // Có hai hình thức truyền tham số cho phương thức khi nó được gọi là tham trị và tham chiếu
            // a. tham trị là cách thức mặc định khi tham số đó là kiểu giá trị.
            //  Có nghĩa là gán tham số bằng một biến, thì giá trị của biến được copy
            //  và sử dụng trong phương thức như biến cục bộ, còn bản thân biến bên ngoài không hề ảnh hưởng.

            // b. tham chiếu là cách thức mặc định khi tham số đó là kiểu tham chiếu,
            //  thì bản thân biến ở tham số sẽ được hàm sử dụng trực tiếp(tham chiếu) chứ không tạo ra một biến cục bộ trong hàm,
            //  nên nó có tác động trực tiếp đến biến này bên ngoài.


            


        }
    }
}
