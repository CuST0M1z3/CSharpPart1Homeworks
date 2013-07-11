using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class ApplyBonusScore
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        int caseSwitch = 0;

        if (number >= 1 && number <= 9)
        {
            if (number >= 1 && number <= 3)
            {
                caseSwitch = 1;
            }
            else if (number >= 4 && number <= 6)
            {
                caseSwitch = 2;
            }
            else if (number >= 7 && number <= 9)
            {
                caseSwitch = 3;
            }
        }
        else
        {
            Console.WriteLine("Enter valid integer between 1 and 9");
        }
        switch (caseSwitch)
        {
            case 1:
                number = number * 10;
                Console.WriteLine("The number is: " + number);
                break;

            case 2:
                number = number * 100;
                Console.WriteLine("The number is: " + number);
                break;

            case 3:
                number = number * 1000;
                Console.WriteLine("The number is: " + number);
                break;
            default:
                Console.WriteLine("Invalid input");
                break;
        }
    }
}

