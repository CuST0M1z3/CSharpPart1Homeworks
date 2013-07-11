using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class ThreeIntegers
{
    static void Main()
    {
        string strA = Console.ReadLine();
        string strB = Console.ReadLine();
        string strC = Console.ReadLine();
        int numberOne = int.Parse(strA);
        int numberTwo = int.Parse(strB);
        int numberThree = int.Parse(strC);

        int sum = (numberOne + numberTwo + numberThree);

        Console.WriteLine("The sum is: " + sum);
    }
}

