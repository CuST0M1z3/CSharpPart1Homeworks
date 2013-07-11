using System;
using System.Numerics;

class CatalanNumbers
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());

        BigInteger factorialA = 1;
        BigInteger factorialB = 1;
        BigInteger factorialC = 1;

        BigInteger catalanNumber = 0;

        if (number >= 0)
        {
            for (int i = 1; i <= 2*number; i++)
            {
                factorialA *= i;
            }

            for (int i = 1; i <= (number + 1); i++)
            {
                factorialB *= i;
            }

            for (int i = 1; i <= number; i++)
            {
                factorialC *= i;
            }
        }

        catalanNumber = factorialA / (factorialB * factorialC);
            
        Console.WriteLine("Nth Catalan number is: " + catalanNumber);
    }
}

