using System;
using System.Linq;

namespace OddAndEvenProduct
{
    class Program
    {
        static void Main()
        {
            short N = short.Parse(Console.ReadLine());
            if (N < 4 || N > 50) { return; }
            string input = Console.ReadLine().Trim();
            ulong[] inputArray = input.Split(' ').Select(ulong.Parse).ToArray();
            ulong productOdd = 1;
            ulong productEven = 1;

            for (int i = 0; i < inputArray.Length; i++)
            {
                if (i % 2 == 0)
                {
                    productOdd *= inputArray[i];
                }
                else
                {
                    productEven *= inputArray[i];
                }
            }

            if (productEven == productOdd)
            {
                Console.WriteLine("yes {0}",productEven);
            }
            else
            {
                Console.WriteLine("no {0} {1}",productOdd,productEven);
            }
        }
    }
}
