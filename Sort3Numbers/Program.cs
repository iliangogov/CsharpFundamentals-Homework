using System;


namespace Sort3Numbers
{
    class Program
    {
        static void Main()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            if(a<b)
            {
                if(b<c)
                {
                    Console.WriteLine("{0} {1} {2}", c, b, a);
                }
                else
                {
                    if(a<c)
                    {
                        Console.WriteLine("{0} {1} {2}", b, c, a);
                    }
                    else
                    {
                        Console.WriteLine("{0} {1} {2}", b, a, c);
                    }
                }
            }
            else
            {
                if(b>c)
                {
                    Console.WriteLine("{0} {1} {2}", a, b, c);
                }
                else
                {
                    if(a>c)
                    {
                        Console.WriteLine("{0} {1} {2}", a, c, b);
                    }
                    else
                    {
                        Console.WriteLine("{0} {1} {2}", c, a, b);
                    }
                }
            }
        }
    }
}
