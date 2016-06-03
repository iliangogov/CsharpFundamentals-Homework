using System;


namespace Fibonacci_Numbers
{
    class Program
    {
        static void Main()
        {
            double N = double.Parse(Console.ReadLine());
            int i;
            ulong x = 1;
            ulong y = 0;
            for (i = 1; i <= N; i++)
            {
                bool b = i != N; //proverqvam dali e posleden 4len na redicata
                Console.Write(b?"{0}, ":"{0}", y);//printvam posledniq 4len bez zapetaq i space*po uslovie
                y = y + x;
                x = y - x;
            }
            Console.WriteLine();
        }
    }
}
