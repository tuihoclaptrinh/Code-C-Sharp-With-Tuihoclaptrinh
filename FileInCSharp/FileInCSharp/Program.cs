using System;
using System.IO;

namespace FileInCSharp
{
    //-------------------------------------------- DriveInfo -------------------------------------------------
    //IsReady	            true ổ đĩa ở trạng thái sẵn sàng (hoạt động) - ví dụ ổ đĩa CD nếu không có đĩa
    //                      thì không sẵn sàng false
    //DriveType             kiểu ổ đĩa(System.IO.DriveType) : CDRom, Fixed, Network, NoRootDirectory, Ram, Removable, Unknown
    //VolumeLabel           Nhãn đĩa
    //DriveFormat           Chuỗi cho biết định dạng đĩa: NTFS, FAT32, FAT, devfs...
    //AvailableFreeSpace    Số byte có hiệu lực còn trống(theo hạn ngạch người dùng)
    //TotalFreeSpace        Số byte còn trống
    //TotalSize             Tổng số byte trên đĩa

    //--------------------------------------- Path ----------------------------------------------------------
    //Path.DirectorySeparatorChar	Thuộc tính chứa ký tự phân cách đường dẫn thư mục (\ trên Windows, / trên *nix)
    //    Path.PathSeparator        Thuộc tính chứa ký tự phân chia thư mục trong biến môi trường
    //Combine                       Kết hợp các chuỗi thành dường dẫn
    //      var path = Path.Combine("home", "ReadMe.txt"); //  "home/ReadMe.txt"
    //ChangeExtension               Thay đổi phần mở rộng của đường dẫn
    //      var path = Path.ChangeExtension("/home/abc/ReadMe.txt", "md"); //  "/home/abc/ReadMe.md"
    //GetDirectoryName              Lấy đường dẫn đến file(thư mục)
    //var path = Path.GetDirectoryName("/home/abc/zyz/ReadMe.txt"); //  "/home/abc/zyz"
    //GetExtension                  Lấy phần mở rộng
    //      var path = Path.GetExtension("/home/ReadMe.txt"); //  ".txt"
    //GetFileName                   Lấy tên file
    //      var path = Path.GetFileName("/home/abc/ReadMe.txt"); //  "ReadMe.txt"
    //GetFileNameWithoutExtension   Lấy tên file
    //      var path = Path.GetFileNameWithoutExtension("/home/ReadMe.txt"); //  "ReadMe"
    //GetFullPath                   Lấy đường dẫn đầy đủ - từ đường dẫn tương đối
    //      var path = Path.GetFullPath("ReadMe.txt");
    //GetPathRoot                   Lấy gốc của đường dẫn
    //GetRandomFileName             Tạo tên file ngẫu nhiên
    //      var path = Path.GetRandomFileName();
    //GetTempFileName               Tạo file duy nhất, rỗng
    //      var path = Path.GetTempFileName();

    //----------------------------------------- Directory ----------------------------------------------------
    //Exists(path)	            Kiểm tra xem thư mục có tồn tại (true) hay không (false)
    //CreateDirectory(path)     Tạo thư mục, trả về đối tượng System.IO.DirectoryInfo chứa thông tin thư mục.
    //Delete(path)              Xóa thư mục.
    //GetFiles(path)            Lấy các file trong thư mục.
    //GetDirectories(path)      Lấy các thư mục trong thư mục.
    //Move(src, des)            Di chuyển thư mục.
    class Program
    {
        /// <summary>
        /// In các thông tin ổ đĩa trong máy
        /// </summary>
        public static void GetDrivesInfo()
        {
            DriveInfo[] allDrives = DriveInfo.GetDrives();

            foreach (DriveInfo d in allDrives)
            {
                Console.WriteLine("Drive {0}", d.Name);
                Console.WriteLine("  Drive type: {0}", d.DriveType);
                if (d.IsReady == true)
                {
                    Console.WriteLine("  Volume label: {0}", d.VolumeLabel);
                    Console.WriteLine("  File system: {0}", d.DriveFormat);
                    Console.WriteLine("  Available space to current user:{0, 15} bytes", d.AvailableFreeSpace);
                    Console.WriteLine("  Total available space:          {0, 15} bytes", d.TotalFreeSpace);
                    Console.WriteLine("  Total size of drive:            {0, 15} bytes ", d.TotalSize);
                }
            }
        }
        static void Main(string[] args)
        {
            //DriveInfo drive = new DriveInfo("D:/");

            //Console.WriteLine($"Drive: {drive.Name}");
            //Console.WriteLine($"Drive type: {drive.DriveType}");
            //Console.WriteLine($"Label: {drive.VolumeLabel}");
            //Console.WriteLine($"Format: {drive.DriveFormat}");
            //Console.WriteLine($"Size: {drive.TotalSize}");
            //Console.WriteLine($"Free: {drive.TotalFreeSpace}");

            //GetDrivesInfo();

            var directory_mydoc = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            String[] files = System.IO.Directory.GetFiles(directory_mydoc);
            String[] directories = System.IO.Directory.GetDirectories(directory_mydoc);

            foreach (var file in files)
            {
                Console.WriteLine(file);
            }

            //foreach (var directory in directories)
            //{
            //    Console.WriteLine(directory);
            //}

            //string path = "tuihoclaptrinh";

            //Directory.Delete(path);

            //Directory.CreateDirectory(path);

            //if (Directory.Exists(path))
            //{
            //    Console.WriteLine($"{path} - Ton tai");
            //} else
            //{
            //    Console.WriteLine($"{path} - Khong ton tai");
            //}

            //string path = "ref";

            //var files = Directory.GetFiles(path);

            //var directories = Directory.GetDirectories(path);

            //foreach (var directory in directories)
            //{
            //    Console.WriteLine(directory);
            //}

            //foreach (var file in files)
            //{
            //    Console.WriteLine(file);
            //}

        }
    }
}
