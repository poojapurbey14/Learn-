using System;

namespace Learn
{
    class Program
    {
        static void Main(string[] args)

        {
            Program program = new Program();
            Console.WriteLine($"Sum of 2+3+4 is  :{program.MyMethod(2, 3, 4)}");
        }
        public int MyMethod(int a,int b,int c)
        {
            return a + b + c;
        }
    }
}
