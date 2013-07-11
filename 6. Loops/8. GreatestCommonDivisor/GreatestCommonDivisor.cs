using System;

class GreatestCommonDivisor
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());

        int gcd;

        if (a > b)
        {
            for (int i = 0; a > b; i++)
            {
                a = a - b;

                for (int j = 0; b > a; j++)
                {
                    b = b - a;
                }
            }
        }

        if (b > a)
        {
            for (int j = 0; b > a; j++)
            {
                b = b - a;

                for (int i = 0; a > b; i++)
                {
                    a = a - b;
                }
            }
        }

        if (a == b)
        {
            gcd = a;
            Console.WriteLine("Greatest common divisor is: " + gcd);
        }
           
    }
}

