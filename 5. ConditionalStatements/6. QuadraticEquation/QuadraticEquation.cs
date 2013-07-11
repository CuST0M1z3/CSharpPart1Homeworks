using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class QuadraticEquation
{
    static void Main()
    {
        string firstNumber = Console.ReadLine();
        string secondNumber = Console.ReadLine();
        string thirdNumber = Console.ReadLine();
        int a = int.Parse(firstNumber);
        int b = int.Parse(secondNumber);
        int c = int.Parse(thirdNumber);

        double x1 = 0;
        double x2 = 0;
        int discriminant = 0;

        discriminant = ((b * b) - (4 * a * c));
        x1 = (-b + (Math.Sqrt(discriminant))) / (2 * a);
        x2 = (-b - (Math.Sqrt(discriminant))) / (2 * a);

        if (discriminant < 0)
        {
            Console.WriteLine("No real roots");
        }
        else if (discriminant == 0)
        {
            Console.WriteLine("There is one real root x1 = x2 = " + x1);
        }
        else if (discriminant > 0)
        {
            Console.WriteLine("There are two real roots: x1 = " + x1 + " x2 = " + x2);
        }
    }
}

