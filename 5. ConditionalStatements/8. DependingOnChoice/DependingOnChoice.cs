using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class DependingOnChoice
{
    static void Main()
    {
        string number = Console.ReadLine();
        int num;
        double dNum;

        bool result1 = int.TryParse(number, out num);
        bool result2 = double.TryParse(number, out dNum);

        int caseSwitch = 0;

        if (result1 == true)
        {
            caseSwitch = 1;
        }
        else if (result2 == true)
        {
            caseSwitch = 2;
        }
        else if ((result1 == false) && (result2 == false))
        {
            caseSwitch = 3;
        }

        switch (caseSwitch)
        {
            case 1:
                num = num + 1;
                Console.WriteLine("The num is: " + num);
                break;

            case 2:
                dNum = dNum + 1;
                Console.WriteLine("The double num is: " + dNum);
                break;

            case 3:
                number = number + "*";
                Console.WriteLine("The string is: " + number);
                break;
            default:
                Console.WriteLine("Invalid input");
                break;      
        }
    }
}

