using System;



class NumbersFrom1toN
{
    static void Main()
    {
        Console.Write("Enter N: ");
        string str = Console.ReadLine();
        int n = int.Parse(str);

        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine(i);
        }
    }
}

