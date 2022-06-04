using System;
using System.Linq;

namespace ArrayInCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Array 
            // 0 | 1 | 2 |  3  |  4  |  5  |  6  | ----- Index (indices)
            // a | 2 | 5 | abc | bbb | @aa | 123 | ----- Element (at index)
            // <--------- Array Lenght ---------->

            // 1. Khởi tạo mảng (Khai báo mảng)
                // cách 1:
                int[] ExArray;
                ExArray = new int[5];
                // cách 2:
                string[] ExStringArray = new string[10];
                // cách 3:
                string[] productNames = new string[3] { "Iphone", "Samsung", "Nokia" };
                double[] productPrices = new double[3] { 100, 200.5, 10.1 };
                //Cách 4:
                string[] cars = { "Honda", "BMW", "Yamaha", "Mercedes" };
                int[] ages = { 21, 23, 9, 54 };

            // 2. Truy cập phần tử mảng
                Console.WriteLine(productNames[0]);
                Console.WriteLine(productPrices[1]);
                Console.WriteLine(cars[2]);
                Console.WriteLine(ages[3]);

            // 3. Thay đổi một phần tử trong mảng
                cars[0] = "Honda version 2";
                Console.WriteLine(cars[0]);

            // 4. Thuộc tính và phương thức đối tượng mảng
                // a. Lớp System.Array là lớp cơ sở của các biến mảng,
                //      và có 1 số thuộc tính sau:
                    // 1. Lengh: Thuộc tính cho biết số lượng phần tử trong mảng
                        Console.WriteLine(productNames.Length);
                        Console.WriteLine(productPrices.Length);
                        Console.WriteLine(cars.Length);
                        Console.WriteLine(ages.Length);
                    // 2. Rank: Thuộc tính cho biết số chiều mảng
                        Console.WriteLine(productNames.Rank);
                        Console.WriteLine(productPrices.Rank);
                        Console.WriteLine(cars.Rank);
                        Console.WriteLine(ages.Rank);
                    // 3. Clone(): Copy (nhân bản) đối tượng mảng
                        string[] carsClone = (string[]) cars.Clone();
                        Console.WriteLine(carsClone[0]);
                    // 4. GetValue(index): Lấy giá trị phần tử trong mảng
                        Console.WriteLine(carsClone.GetValue(1));
                    // NOTE : using thư viện using System.Linq; ở đầu để dùng được 5,6,7
                    // 5. Min(): Trả về giá trị nhỏ nhất trong mảng
                        Console.WriteLine(carsClone.Min());
                    // 6. Max(): Trả về giá trị nhỏ nhất trong mảng
                        Console.WriteLine(ages.Max());
                    // 7. Sum(): Trả về giá trị tổng cộng các phần tử
                        Console.WriteLine(ages.Sum()); // không sum() string
                // b. Một số phương thức tĩnh trong Array áp dụng vào mảng như:
                    // 1. Array.BinarySearch(array, value) : Tìm kiếm phần tử trong mảng
                    //      đã được sắp xếp, trả về chỉ số nếu tìm thấy (< 0 -> không tìm thấy
                    //      > 0 thì trả về vị trí tìm thấy (index))
                        Console.WriteLine(Array.BinarySearch(ages, 54));
                    // 2. CopyTo(array, indexStart): Sao chép phần tử mảng này sang mảng khác
                        int[] ageCoppy = new int[4];
                        Array.Copy(ages, ageCoppy, 4);
                        Console.WriteLine(ageCoppy[3]);
                    // 3. Array.Clear(array, index, length): Thiết lập phần tử mảng
                    //      nhận giá trị mặc định
                        Array.Clear(ageCoppy, 0, ageCoppy.Length);
                        Console.WriteLine(ageCoppy[3]);
                    // 4. bool Exists<T> (array, Predicate<T> match); : Kiểm tra có phần tử trong mảng
                    //      thỏa mãn match
                        bool a = Array.Exists<int>(ageCoppy, e => e == 54);
                        Console.WriteLine(a);
                    // 5. Fill<T> (array, value); : Gán các phần tử của mảng bằng value
                        Array.Fill(ageCoppy, 3);
                        Console.WriteLine(ageCoppy[0]);
                        Console.WriteLine(ageCoppy[1]);
                        Console.WriteLine(ageCoppy[2]);
                        Console.WriteLine(ageCoppy[3]);
                    // 6. T Find<T> (array, Predicate<T> match); : Tìm phần tử mảng
                        Console.WriteLine(Array.Find<int>(ageCoppy, e => e == 3));
                    // 7. int FindIndex<T> (array, Predicate<T> match); : Tìm phần tử mảng,
                    //      trả về chỉ số nếu thấy
                        Console.WriteLine(Array.FindIndex<int>(ageCoppy, e => e == 3));
                    // 8. T[] FindAll<T> (array, Predicate<T> match); : Tìm tất cả phần tử mảng
                        foreach (int i in Array.FindAll(ageCoppy, e => e == 3))
                        {
                            Console.WriteLine(i);
                        }
                    // 9. int IndexOf(array, value) : Tìm chỉ số của phần tử
                        Console.WriteLine(Array.IndexOf(ageCoppy, 3));
                    // 10. ForEach(array, Action<T> action) : Thi hành action trên mỗi phần tử
                        Array.ForEach(ageCoppy, (int n) => Console.WriteLine(n));
                    // 11.Sort(array) : Sắp xếp
                        Array.Sort(ages);
                        Array.ForEach(ages, (int n) => Console.WriteLine(n));
                // c. Duyệt qua các phần tử trong mảng
                    // 1. For: 
                        int[] myArray = { 1, 3, 5, 19, 10, 20, 40, 40 };
                        int maxIndex = myArray.Length - 1;
                        for (int idx = 0; idx <= maxIndex; idx++)
                        {
                            Console.WriteLine(myArray[idx]);
                        }
                    // 2. Foreach:
                        int[] myArray2 = { 1, 3, 5, 19, 10, 20, 40, 40 };
                        foreach (int element in myArray2)
                        {
                            Console.WriteLine(element);
                        }
            // 5. Mảng nhiều chiều
                // type[, , … ,] varname = new type[size1, size2, …, sizeN];
                    int[,] myvar = new int[3, 4] { { 1, 2, 3, 4 }, { 0, 3, 1, 3 }, { 4, 2, 3, 4 } };   
                                                        // khai báo và khởi tạo mảng 2 chiều

                    for (int i = 0; i <= 2; i++)     // duyệt qua từng hàng
                    {
                        for (int j = 0; j <= 3; j++)         // duyệt qua từng cột
                        {
                            Console.Write(myvar[i, j] + " ");
                        }
                        Console.WriteLine();
                    }
                                    // 1 2 3 4
                                    // 0 3 1 3
                                    // 4 2 3 4

            // 6. Mảng trong mảng
                int[][] myArray3 = new int[][] {
                                    new int[] {1,2},
                                    new int[] {2,5,6},
                                    new int[] {2,3},
                                    new int[] {2,3,4,5,5}
                                   };

                foreach (var arr in myArray3)
                {
                    foreach (var e in arr)
                    {
                        Console.Write(e + " ");
                    }
                    Console.WriteLine();
                }

                                    // 1 2
                                    // 2 5 6
                                    // 2 3
                                    // 2 3 4 5 5
        }
    }
}
