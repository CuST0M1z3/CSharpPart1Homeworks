using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class SetValue
{
    static void Main()
    {
        string str = Console.ReadLine();
        int number = int.Parse(str);
        string strP = Console.ReadLine();
        int p = int.Parse(strP);
        string strV = Console.ReadLine();
        int v = int.Parse(strV);
        int mask;
        int result;
        if (v == 0)
        {
            mask = ~(1 << p);
            result = number & mask;
            Console.WriteLine(result);
        }
        else
        {
            mask = 1 << p;
            result = number | mask;
            Console.WriteLine(result);
        }
    }
}

