using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class PrintingTriangle
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;

        char symbol = '\u00A9';

        for (int i = 1; i <= 9; i++)
        {
            Console.Write(new string(' ',10 - i)); // add white spaces
            for (int j = 1; j <= i; j++)
            {
                Console.Write("{0} ", symbol);
            }
            Console.WriteLine();
        }
        
    }
}

