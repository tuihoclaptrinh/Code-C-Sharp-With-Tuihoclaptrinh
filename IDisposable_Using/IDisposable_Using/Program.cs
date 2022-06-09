using System;

namespace IDisposable_Using
{
    // các thao tác để giải phóng các tài nguyên chiếm giữ - khi đối tượng bị hủy
    // Tại sao cần tự giải phóng tài nguyên:
    // Như đã biết, trong .NET hầu hết các loại tài nguyên là được quản lý bởi CLR của hệ thống .NET,
    // nên các tài nguyên, đối tượng không còn tham chiếu đến nó sẽ tự động được CLR thu hồi (GC).
    // Đó là những tài nguyên quản lý được bởi .NET CLR

    // Tuy nhiên, vẫn có những loại tài nguyên mà CLR.NET không quản lý được như:
    // Mở file - stream
    // Các kết nối mạng, kết nối đến CSDL ...
    // Những vùng bộ nhớ không quản lý được, các font chữ ...
    // Với những loại tài nguyên này, .NET không biết tự giải phóng nó thế nào,
    // nên bạn phải có một cơ chế chủ động làm việc này khi không còn dùng đến nữa.
    // Bạn cần viết code giải phóng tài nguyên thích hợp ở phương thức hủy (Finalize)
    // và có thể là triển khai giao diện IDisposable để sử dụng với câu lệnh using

    class A : IDisposable
    {
        bool resource = true;
        public void Dispose()
        {
            Console.WriteLine("Phương thức này gọi tự động khi hết using");
            resource = false; // giải phóng tài nguyên
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            using (var a = new A())
            {
                Console.WriteLine("Do something ...");
            }
        }
    }
}
