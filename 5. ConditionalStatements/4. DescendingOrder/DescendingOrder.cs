using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class DescendingOrder
{
    static void Main()
    {
        string firstNumber = Console.ReadLine();
        string secondNumber = Console.ReadLine();
        string thirdNumber = Console.ReadLine();
        float numberOne = float.Parse(firstNumber);
        float numberTwo = float.Parse(secondNumber);
        float numberThree = float.Parse(thirdNumber);

        if ((numberOne >= numberTwo) && (numberTwo >= numberThree))
        {
            Console.WriteLine("Descending order: " + numberOne + " " + numberTwo + " " + numberThree);
        }
        else if ((numberOne >= numberThree) && (numberThree >= numberTwo))
        {
            Console.WriteLine("Descending order: " + numberOne + " " + numberThree + " " + numberTwo);
        }
        else if ((numberTwo >= numberOne) && (numberOne >= numberThree))
        {
            Console.WriteLine("Descending order: " + numberTwo + " " + numberOne + " " + numberThree);
        }
        else if ((numberTwo >= numberThree) && (numberThree >= numberOne))
        {
            Console.WriteLine("Descending order: " + numberTwo + " " + numberThree + " " + numberOne);
        }
        else if ((numberThree >= numberOne) && (numberTwo >= numberOne))
        {
            Console.WriteLine("Descending order: " + numberThree + " " + numberTwo + " " + numberOne);
        }
        else if ((numberThree >= numberTwo) && (numberOne >= numberTwo))
        {
            Console.WriteLine("Descending order: " + numberThree + " " + numberOne + " " + numberTwo);
        }
    }
}

