using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class ExistNumbers
{
    static void Main()
    {
        string strA = Console.ReadLine();
        string strB = Console.ReadLine();
        int a = int.Parse(strA);
        int b = int.Parse(strB);

        if (a < b)
        {
            for (int i = a; i <= b; i++)
            {
                if (i % 5 == 0)
                {
                    Console.WriteLine("The numbers are: " + i);
                }  
            }
        }
        else
        {
            Console.WriteLine("Enter number b which is greater than number a");
        }
    }
}

