using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class PointWithinCircle
{
    static void Main()
    {
        string strX = Console.ReadLine();
        string strY = Console.ReadLine();
        double x = double.Parse(strX);
        double y = double.Parse(strY);
        double radius = 5;

        if ((x*x + y*y) <= radius*radius)
        {
            Console.WriteLine("Point with coordinates x: {0} and y: {1} is within the circle K(0,5)", x, y);
        }
        else
        {
            Console.WriteLine("Point with coordinates x: {0} and y: {1} is out of the circle K(0,5)", x, y);
        }
    }
}

