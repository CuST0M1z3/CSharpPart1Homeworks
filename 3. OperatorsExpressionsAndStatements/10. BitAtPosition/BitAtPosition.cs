using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class BitAtPosition
{
    static void Main()
    {
        string str = Console.ReadLine();
        int number = int.Parse(str);
        string strP = Console.ReadLine();
        int p = int.Parse(strP);
        int mask = 1 << p;
        int nAndMask = number & mask;
        int bit = nAndMask >> p;
        if (bit == 1)
        {
            Console.WriteLine(true);
        }
        else
        {
            Console.WriteLine(false);
        }
    }
}

