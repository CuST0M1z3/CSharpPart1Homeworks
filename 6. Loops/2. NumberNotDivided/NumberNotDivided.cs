using System;


class NumberNotDivided
{
    static void Main()
    {
        Console.Write("Enter N: ");
        string str = Console.ReadLine();
        int n = int.Parse(str);

        for (int i = 1; i <= n; i++)
        {
            if (i % 3 != 0 && i % 7 != 0)
            {
                Console.WriteLine(i);
            }
        }
    }
}

