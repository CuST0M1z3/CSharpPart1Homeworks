using System;


class FactorialDivide
{
    static void Main()
    {
        Console.Write("Enter N: ");
        string strN = Console.ReadLine();
        int n = int.Parse(strN);
        Console.Write("Enter K: ");
        string strK = Console.ReadLine();
        int k = int.Parse(strK);
        decimal factorialN = 1;
        decimal factorialK = 1;

        if (1 < k && k < n)
        {
            for (int i = 1; i <= n; i++)
            {
                factorialN *= i;
            }
            for (int j = 1; j <= k; j++)
            {
                factorialK *= j;
            }
            Console.WriteLine("N!/K! = " + (factorialN / factorialK));
        }
        else
        {
            Console.WriteLine("You have enter invalid numbers");
        }
        
    }
}

