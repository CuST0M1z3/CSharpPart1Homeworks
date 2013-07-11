using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class OddOrEven
{
    static void Main()
    {
        string str = Console.ReadLine();
        int number = int.Parse(str);

        if (number % 2 == 0)
        {
            Console.WriteLine("The number is even");
        }
        else
        {
            Console.WriteLine("The number is odd");
        }
    }
}

