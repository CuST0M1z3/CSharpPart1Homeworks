using System;


class SumCalculating
{
    static void Main()
    {
        Console.Write("Enter N: ");
        string strN = Console.ReadLine();
        int n = int.Parse(strN);
        Console.Write("Enter X: ");
        string strX = Console.ReadLine();
        int x = int.Parse(strX);
        decimal sum = 1;
        decimal factorial = 1;
        decimal product = 1;

        for (int i = 1; i <= n; i++)
        {
            factorial *= i;
            product *= x;
            sum += (factorial / product);
        }
        Console.WriteLine("The sum is: " + sum);
    }
}

