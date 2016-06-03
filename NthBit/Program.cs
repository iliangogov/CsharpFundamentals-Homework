using System;

namespace NthBit
{
    class Program
    {
        static void Main()
        {
            uint p = uint.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            // int mask = 1 << n;     //premestva bit1 na NthBit
            //long pMask = p & mask;//ako NthBit e 1 toi si ostava 1,ako NthBit e 0 si ostava 0 ot& operatora
            // long b =pMask >> n; //premestva NthBit na posledna poziciq
            long b = (p >> n)&1;//nai kratko reshenie!!!
            Console.WriteLine(b);//printirame NthBit
        }
    }
}
