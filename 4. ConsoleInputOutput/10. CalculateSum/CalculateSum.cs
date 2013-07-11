using System;

class CalculateSum
{
    static void Main()
    {
        string strN = Console.ReadLine();
        double n = double.Parse(strN);
        double sum = 1.0;
        int precision = 3;

        for (int i = 2; i <= n; i++)
        {
            if (i % 2 == 0)
            {
                sum += (1.0/i);
                sum = Math.Round(sum, precision);
            }
            else
            {
                sum -= (1.0 / i);
                sum = Math.Round(sum, precision);
            }
        }
        Console.WriteLine(sum);
    }
}
