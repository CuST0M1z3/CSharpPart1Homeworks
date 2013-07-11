using System;


class IntegerValuesExchange
{
    static void Main()
    {
        int firstNumber = 5;
        int secondNumber = 10;
        int thirdNumber = 0;

        thirdNumber = firstNumber;
        firstNumber = secondNumber;
        secondNumber = thirdNumber;


        Console.WriteLine("First number is: " + firstNumber);
        Console.WriteLine("Second number is: " + secondNumber);
    }
}

