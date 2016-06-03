using System;

namespace PrimeNumber
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            bool prime = (n>0)&&(n<=100) && ((n==2 || n==3 || n==5 || n==7) || (n%2!=0 && n%3!=0 && n%5!=0 && n%7!=0 ));
            Console.WriteLine(prime ? "true":"false");
        }
    }
}
