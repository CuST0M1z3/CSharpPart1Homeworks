using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class DividedOrNo
{
    static void Main()
    {
        string str = Console.ReadLine();
        int number = int.Parse(str);

        if (number % 35 == 0)
        {
            Console.WriteLine(true);
        }
        else
        {
            Console.WriteLine(false);
        }
    }
}

