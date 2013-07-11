using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class ThirdDigit
{
    static void Main()
    {
        string str = Console.ReadLine();
        int number = int.Parse(str);

        int firstResult = number / 100;
        int result = firstResult % 10;

        if (result == 7)
        {
            Console.WriteLine(true);
        }
        else
        {
            Console.WriteLine(false);
        }
    }
}

