using System;

namespace Generic
{
    class Program
    {
        static void Info<T, S>(int age, string name)
        {
            Console.WriteLine($"{name} nam nay {age} tuoi");
        }
        static void Main(string[] args)
        {
            Info<int, string>(22, "Tuan Anh");

            GenericClass<int> IntID = new GenericClass<int>();
            IntID.SetID(123);
            IntID.Infomation();

            GenericClass<string> StringID = new GenericClass<string>();
            StringID.SetID("DE140172");
            StringID.Infomation();

        }
    }
}
