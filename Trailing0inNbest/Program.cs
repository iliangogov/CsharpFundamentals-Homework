using System;
namespace OddAndEvenProduct
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            long trailinZeroes = 0;
            int power = 1;

            do
            {
                trailinZeroes += n / (long)Math.Pow(5, power);
                power++;

            } while (Math.Pow(5, power) <= n);

            Console.WriteLine(trailinZeroes);
        }
    }
}
