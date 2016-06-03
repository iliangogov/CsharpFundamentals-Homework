using System;

namespace MatrixOfNumbers
{
    class Program
    {
        static void Main()
        {
            int N=int.Parse(Console.ReadLine());
            int i;
            for(i=0;i<N;i++)
            {
                for (int c = i+1; c <= N + i; c++)
                {
                    Console.Write("{0} ", c);
                }
                Console.WriteLine();
            }
        }
    }
}
