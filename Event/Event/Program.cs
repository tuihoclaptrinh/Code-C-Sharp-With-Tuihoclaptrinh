using System;

namespace Event
{
    public delegate void EvenInput(int x);

    /*
         
        publisher -> class - phat su kien
        subcriber -> class - nhan su kien
         
    */

    // publisher
    class UserInput
    {
        public EvenInput eveninput { get; set; }
        public void Input()
        {
            do
            {
                Console.Write("Nhap vao 1 so nguyen: ");
                string s = Console.ReadLine();
                int i = Int32.Parse(s);
                // phat su kien
                eveninput?.Invoke(i);
            }
            while (true);
        }
    }

    class TinhCan
    {
        public void Sub(UserInput input)
        {
            input.eveninput = Can;
        }
        public void Can(int i)
        {
            Console.WriteLine($"Can bac hai cua so {i} la {Math.Sqrt(i)}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // publisher
            UserInput userInput = new UserInput();
            //userInput.Input();

            TinhCan tinhCan = new TinhCan();
            tinhCan.Sub(userInput);

            userInput.Input();
        }
    }
}
