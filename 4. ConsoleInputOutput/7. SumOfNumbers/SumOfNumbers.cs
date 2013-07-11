using System;

class SumOfNumbers
{
    static void Main()
    {
        string strN = Console.ReadLine();
        int n = int.Parse(strN);
        int sum = n;


        for (int i = 0; i < n; i++)
        {
            string strK = Console.ReadLine();
            int k = int.Parse(strK);

            sum += k;
        }
        Console.WriteLine("The sum is: " + sum);
    }
}

