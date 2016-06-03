using System;

namespace GreatestCommonDivisor
{
    class Program
    {
        static void Main()
        {
            string ab = Console.ReadLine();
            int a = int.Parse(ab.Split(' ')[0]);
            int b = int.Parse(ab.Split(' ')[1]);
          
            int reminder = 0;

            while (b != 0)
            {
                reminder = b;
                b = a % b;
                a = reminder;
            }

            Console.WriteLine(Math.Abs(a));
        }
    }
}
