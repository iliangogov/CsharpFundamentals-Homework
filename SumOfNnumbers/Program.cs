using System;


namespace SumOfNnumbers
{
    class Program
    {
        static void Main()
        {
            double N = double.Parse(Console.ReadLine());
            int i;
            double sum=0;
            for (i = 1; i <= N; i++)
            {
                sum += double.Parse(Console.ReadLine());
            }
            Console.WriteLine(sum);
        }
    }
}
