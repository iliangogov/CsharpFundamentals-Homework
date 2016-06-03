using System;

namespace ModifyBit
{
    class Program
    {
        static void Main()
        {
            uint n = uint.Parse(Console.ReadLine());
            ushort p = ushort.Parse(Console.ReadLine());
            uint v = uint.Parse(Console.ReadLine());
            long a = n & (~(1 << p)) | (v << p);
            Console.WriteLine( a);
        }
    }
}
