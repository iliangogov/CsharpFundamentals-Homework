using System;

namespace PrintLongSequence
{
    class Program
    {
        static void Main()
        {
            int member;
            for (int i = 2; i <= 1001; i++)
            {
                if (i % 2 == 0)
                    member = i;
                else
                    member = i * (-1);

                Console.WriteLine(member);
            }
        }
    }
}
