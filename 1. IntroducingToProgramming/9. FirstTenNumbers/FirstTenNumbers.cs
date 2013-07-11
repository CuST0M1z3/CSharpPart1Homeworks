using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class FirstTenNumbers
{
    static void Main()
    {
        int[] numbers = new int[12];

        for (int i = 2; i < numbers.Length; i++)
        {
            if (i % 2 == 0)
            {
                numbers[i] = i;
            }
            else
            {
                numbers[i] = -i;
            }
            Console.WriteLine(numbers[i]);
        }
    }
}

