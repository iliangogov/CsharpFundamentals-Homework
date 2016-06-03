using System;

namespace MoonGravity
{
    class Program
    {
        static void Main()
        {
            float W = float.Parse(Console.ReadLine());
            double moon = (W / 100) * 17;
            double moonRound = Math.Round(moon, 3);
            Console.WriteLine("{0:0.000}", moonRound);
        }
    }
}
