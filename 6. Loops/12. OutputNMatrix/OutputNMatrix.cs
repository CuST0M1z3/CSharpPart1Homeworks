using System;


class OutputNMatrix
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int[,] m = new int[n, n];

        if (n >= 1 && n < 20)
        {
            for (int col = 0; col < n; col++)
            {
                for (int row = 1; row <= n; row++)
                {
                    if (row + col < 10)
                    {
                        Console.Write(row + col + "  ");
                    }
                    else
                    {
                        Console.Write(row + col + " ");
                    } 
                }
                Console.WriteLine();
            }
        }
    }
}

