using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class GreaterOne
{
    static void Main()
    {
        string firstNumber = Console.ReadLine();
        string secondNumber = Console.ReadLine();
        int numberOne = int.Parse(firstNumber);
        int numberTwo = int.Parse(secondNumber);
        int greaterNumber = numberOne;

        if (greaterNumber < numberTwo)
        {
            greaterNumber = numberTwo;
        }

        Console.WriteLine("The greater number is " + greaterNumber);
    }
}

