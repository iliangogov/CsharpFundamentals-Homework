using System;

namespace PointCircleRectangle
{
    class Program
    {
        static void Main()
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            double circleBoarder = x * x + y * y;
            double newRadius = Math.Sqrt(circleBoarder);
            bool isInCircle = (x-1) *(x-1) + (y-1) *(y-1) <=1.5*1.5;
            bool isInRectangle = (x >= -1 && x <= 5) && (y <= 1 && y >= -1);
            Console.Write(isInCircle ? "inside circle" : "outside circle");
            Console.WriteLine(isInRectangle ? " inside rectangle" : " outside rectangle");
        }
    }
}
