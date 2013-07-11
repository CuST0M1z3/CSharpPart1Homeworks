using System;


class SumOfFibonacci
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int[] numbers = new int[n];

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

