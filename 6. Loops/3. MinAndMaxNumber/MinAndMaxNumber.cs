using System;


class MinAndMaxNumber
{
    static void Main()
    {
        Console.Write("Enter N: ");
        string str = Console.ReadLine();
        int n = int.Parse(str);
        int maxNumber = 0;
        int minNumber = 10000000;
        for (int i = 0; i < n; i++)
        {
            Console.Write("Enter M: ");
            string strOne = Console.ReadLine();
            int m = int.Parse(strOne);

            if (maxNumber < m)
            {
                maxNumber = m;
            }
            if (minNumber > m)
            {
                minNumber = m;
            }
        }
        Console.WriteLine("Max number is: " + maxNumber);
        Console.WriteLine("Min number is: " + minNumber);
    }
}

