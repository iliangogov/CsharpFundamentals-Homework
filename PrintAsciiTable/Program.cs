using System;

namespace PrintAsciiTable
{
    class Program
    {
        static void Main()
        {
            for (int i = 33;i<=126;i++) 
            {
                char a = (char)i;
                Console.Write(a);
            }
            Console.WriteLine();
        }
    }
}
