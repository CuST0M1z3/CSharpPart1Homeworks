using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class ThirdBit
{
    static void Main()
    {
        string str = Console.ReadLine();
        int number = int.Parse(str);
        int p = 3;
        int mask = 1 << p;
        int nAndMask = number & mask;
        int bit = nAndMask >> p;
        Console.WriteLine("Third bit is " + bit);
    }
}

