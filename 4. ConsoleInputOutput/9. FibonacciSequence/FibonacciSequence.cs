using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class FibonacciSequence
{
    static void Main()
    {
        int[] numbers = new int[100];

        for (int i = 0; i < numbers.Length; i++)
        {
            if (i < 2)
            {
                numbers[i] = 1;
            }
            else
            {
                numbers[i] = numbers[i - 1] + numbers[i - 2];
            }
            Console.WriteLine(numbers[i]);
        }
    }
}

