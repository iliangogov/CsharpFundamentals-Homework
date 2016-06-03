using System;


namespace FormattingNumbers
{
    class Program
    {
        static void Main()
        {
            int a = int. Parse(Console.ReadLine());
            double b=double.Parse(Console.ReadLine());
             double c = double.Parse(Console.ReadLine());
            Console.WriteLine("{0,-5:x} {0:0.000} {1:0.00} {2:0.000}",a,b,c);
           // int i = int.Parse(Console.ReadLine());

            //Console.WriteLine("{0,-5:0.00}", i);
        }
    }
}
