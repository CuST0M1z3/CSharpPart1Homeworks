using System;


class CompareFloatingPoint
{
    static void Main()
    {
        float precision = 0.000001f;

        double firstNumber = 5.00000001f;
        double secondNumber = 5.00000003f;
        float thirdNumber = 5.3f;
        float fourthNumber = 6.01f;

        bool compareOne = (Math.Abs(firstNumber - secondNumber) <= precision);
        bool compareTwo = (Math.Abs(thirdNumber - fourthNumber) <= precision);

        Console.WriteLine(compareOne);
        Console.WriteLine(compareTwo);
    }
}

