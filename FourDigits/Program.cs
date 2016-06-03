using System;

namespace FourDigits
{
    class Program
    {
        static void Main()
        {
            int a=int.Parse(Console.ReadLine(),0000);
            int firstDigit = (a / 1000)%10;
            int secondDigit = (a / 100) % 10;
            int thirdDigit = (a / 10) % 10;
            int fourthDigit = a % 10;
            int sum = firstDigit + secondDigit + thirdDigit + fourthDigit;
            Console.WriteLine(sum);
            Console.WriteLine("{0}{1}{2}{3}", fourthDigit,thirdDigit,secondDigit,firstDigit);
            Console.WriteLine("{0}{1}{2}{3}", fourthDigit,firstDigit,secondDigit,thirdDigit);
            Console.WriteLine("{0}{1}{2}{3}",firstDigit,thirdDigit,secondDigit,fourthDigit);
        }
    }
}
