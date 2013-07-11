using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class TheBiggestInteger
{
    static void Main()
    {
        string firstNumber = Console.ReadLine();
        string secondNumber = Console.ReadLine();
        string thirdNumber = Console.ReadLine();
        int numberOne = int.Parse(firstNumber);
        int numberTwo = int.Parse(secondNumber);
        int numberThree = int.Parse(thirdNumber);

        int biggestNumber = numberOne;

        if (biggestNumber < numberTwo)
        {
            biggestNumber = numberTwo;
        }
        if (biggestNumber < numberThree)
        {
            biggestNumber = numberThree;
        }
       
        Console.WriteLine("The biggest number is: " + biggestNumber);
    }
}

