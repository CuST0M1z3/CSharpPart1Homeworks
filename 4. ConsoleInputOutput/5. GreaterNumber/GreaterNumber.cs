using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class GreaterNumber
{
    static void Main()
    {
        string strA = Console.ReadLine();
        string strB = Console.ReadLine();
        int a = int.Parse(strA);
        int b = int.Parse(strB);
        bool compareNumbers = a > b;
        while (compareNumbers == true)
        {
            Console.WriteLine(a);
            break;
        }
        while (compareNumbers == false)
        {
            Console.WriteLine(b);
            break;
        }
    }
}

