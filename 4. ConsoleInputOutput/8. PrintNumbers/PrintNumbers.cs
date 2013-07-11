using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class PrintNumbers
{
    static void Main()
    {
        string strN = Console.ReadLine();
        int n = int.Parse(strN);

        if (n >= 1)
        {
            for (int i = 0; i <= n; i++)
            {
                Console.Write(i);
            }
        }
        else
        {
            Console.WriteLine("You enter a invalid number");
        }
    }
}

