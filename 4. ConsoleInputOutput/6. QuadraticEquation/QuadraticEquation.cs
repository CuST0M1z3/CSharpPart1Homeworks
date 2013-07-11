using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class QuadraticEquation
{
    static void Main()
    {
        string strA = Console.ReadLine();
        string strB = Console.ReadLine();
        string strC = Console.ReadLine();
        int a = int.Parse(strA);
        int b = int.Parse(strB);
        int c = int.Parse(strC);
        double discriminant = (b * b) - (4 * a * c);
        
        double x1 = ((-b) + Math.Sqrt(discriminant)) / 2;
        double x2 = ((-b) - Math.Sqrt(discriminant)) / 2;

        if (discriminant < 0)
        {
            Console.WriteLine("There are no real roots");
        }
        else if (discriminant == 0)
        {
            Console.WriteLine("There are one real root x1=x2: " + x1);
        }
        else if (discriminant > 0)
        {
            Console.WriteLine("There are two real roots: x1 = {0} and x2 = {1}", x1, x2);
        }
    }
}

