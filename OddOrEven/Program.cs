using System;

namespace OddOrEven
{
    class Program
    {
        static void Main()
        {
            int a = int.Parse(Console.ReadLine());
            bool b = a % 2 != 0;
            Console.WriteLine(b ? "odd " + a : "even " + a);
        }
    }
}
