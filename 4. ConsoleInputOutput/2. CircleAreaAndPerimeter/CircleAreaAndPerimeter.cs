using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class CircleAreaAndPerimeter
{
    static void Main()
    {
        string str = Console.ReadLine();
        double radius = double.Parse(str);
        double PI = 3.14;
        double circleArea = PI * radius * radius;
        double circlePerimeter = 2 * PI * radius;

        Console.WriteLine("The circle area is: " + circleArea);
        Console.WriteLine("The circle perimeter is: " + circlePerimeter); 

    }
}

