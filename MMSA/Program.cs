using System;

namespace MMSA
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int choice;
            double sum = 0;
            double max = double.MinValue;
            double min = double.MaxValue;
            for(choice=1;choice<= n;choice++)
            {
               double number=double.Parse( Console.ReadLine());
                sum += number;
                if (number>max)
                {
                    max = number;
                }
                if(number<min)
                {
                    min = number;
                }
            }
            Console.WriteLine("min={0:0.00}", min);
            Console.WriteLine("max={0:0.00}", max);
            Console.WriteLine("sum={0:0.00}", sum);
            Console.WriteLine("avg={0:0.00}",sum/n);
        }
    }
}
