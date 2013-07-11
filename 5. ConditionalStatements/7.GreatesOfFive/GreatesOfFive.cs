using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class GreatesOfFive
{
    static void Main()
    {
        string firstNumber = Console.ReadLine();
        string secondNumber = Console.ReadLine();
        string thirdNumber = Console.ReadLine();
        string fourNumber = Console.ReadLine();
        string fiveNumber = Console.ReadLine();
        int a = int.Parse(firstNumber);
        int b = int.Parse(secondNumber);
        int c = int.Parse(thirdNumber);
        int e = int.Parse(fourNumber);
        int d = int.Parse(fiveNumber);

        int greatestNumber = a;

        if (greatestNumber < b)
        {
            greatestNumber = b;
        }
        if (greatestNumber < c)
        {
            greatestNumber = c;
        }
        if (greatestNumber < d)
        {
            greatestNumber = d;
        }
        if (greatestNumber < e)
        {
            greatestNumber = e;
        }
        Console.WriteLine("The greatest number is: " + greatestNumber);
    }
}

