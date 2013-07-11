using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class ProductSign
{
    static void Main()
    {
        string firstNumber = Console.ReadLine();
        string secondNumber = Console.ReadLine();
        string thirdNumber = Console.ReadLine();
        float numberOne = float.Parse(firstNumber);
        float numberTwo = float.Parse(secondNumber);
        float numberThree = float.Parse(thirdNumber);

        if (numberOne == 0 || numberTwo == 0 || numberThree == 0)
        {
            Console.WriteLine("The product is zero");
        }
        else if (numberOne > 0 && numberTwo > 0 && numberThree > 0)
        {
            Console.WriteLine("The sign is +");
        }
        else if (numberOne < 0 && numberTwo < 0 && numberThree < 0)
        {
            Console.WriteLine("The sign is -");
        }
        else if (numberOne < 0 && numberTwo < 0 && numberThree > 0)
        {
            Console.WriteLine("The sign is +");
        }
        else if (numberOne < 0 && numberTwo > 0 && numberThree < 0)
        {
            Console.WriteLine("The sign is +");
        }
        else if (numberOne > 0 && numberTwo < 0 && numberThree < 0)
        {
            Console.WriteLine("The sign is +");
        }
        else if (numberOne > 0 && numberTwo > 0 && numberThree < 0)
        {
            Console.WriteLine("The sign is -");
        }
        else if (numberOne > 0 && numberTwo < 0 && numberThree > 0)
        {
            Console.WriteLine("The sign is -");
        }
        else if (numberOne < 0 && numberTwo > 0 && numberThree > 0)
        {
            Console.WriteLine("The sign is -");
        }
    }
}

