using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class ASCIITable
{
    static void Main()
    {
        for (int i = 0; i < 127; i++)
        {
            Console.WriteLine("The character is: " + ((char)i));
        }
    }
}

