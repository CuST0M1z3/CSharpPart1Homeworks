using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class SubsetSumEqualToZero
{
    static void Main()
    {
        int[] arr = new int[5];
        int sum = 0;
        int count = 0;


        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }
        for (int j = 0; j < 5; j++)
        {
            sum = 0;
            for (int k = j; k < 5; k++)
            {
                sum += arr[k];
 
                if (sum == 0)
                {
                    
                    count++;
                    
                }
            }
        }

        Console.WriteLine("The subset sum which is equal to zero are:" + count);
    }
}

