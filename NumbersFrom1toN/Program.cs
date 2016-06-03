using System;

namespace NumbersFrom1toN
{
    class Program
    {
        static void Main()
        {
            uint N = uint.Parse(Console.ReadLine());
            uint i;
            for(i=1;i<= N;i++)
            {
                Console.Write("{0} ", i);
            }
            Console.WriteLine();
        }
    }
}
