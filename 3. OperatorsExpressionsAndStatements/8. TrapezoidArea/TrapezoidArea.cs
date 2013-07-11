using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class TrapezoidArea
{
    static void Main()
    {
        string strOne = Console.ReadLine();
        double a = double.Parse(strOne);
        string strTwo = Console.ReadLine();
        double b = double.Parse(strTwo);
        string strThree = Console.ReadLine();
        double h = double.Parse(strThree);

        double trapezoidArea = ((a+b)/2) * h;

        Console.WriteLine("Trapezoid area is: " + trapezoidArea);

    }
}

