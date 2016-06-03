using System;

namespace PointInCircle
{
    class Program
    {
        static void Main()
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            double circleBoarder= x * x + y * y;
            double newRadius = Math.Sqrt(circleBoarder);
            bool isInCircle = x* x + y* y <= 4;
            Console.WriteLine(isInCircle ? "yes {0:0.00}" :"no {0:0.00}",newRadius);
        }
    }
}
