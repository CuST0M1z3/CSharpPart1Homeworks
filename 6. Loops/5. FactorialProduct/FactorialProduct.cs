using System;


class FactorialProduct
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
        decimal factorial = 1;
        int m = k - n;

        if (1 < n && n < k)
        {
            for (int t = 1; t <= m; t++)
			{
                factorial *= t;
			}
            for (int i = 1; i <= n; i++)
            {
                factorialN *= i;
            }
            for (int j = 1; j <= k; j++)
            {
                factorialK *= j;
            }
            decimal result = ((factorialN * factorialK) / factorial);
            Console.WriteLine("N!*K!/(K-N)! = " + result);
        }
        else
        {
            Console.WriteLine("You have enter invalid numbers");
        }
    }
}

