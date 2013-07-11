using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class WithinCircleOutRectangle
{
    static void Main()
    {
        string strX = Console.ReadLine();
        string strY = Console.ReadLine();
        double pointX = double.Parse(strX);
        double pointY = double.Parse(strY);
        double radius = 3;
        double centerX = 1;
        double centerY = 1;

        if ((((pointX - centerX) * (pointX - centerX)) + ((pointY - centerY) * (pointY - centerY)) <= (radius*radius)) &&
            ((pointX >= -1 && pointX <= 5) && (pointY <= 1 && pointX >= -1)))
        {
            Console.WriteLine("Point with coordinates x: {0} and y: {1} is within the circle K((1,1),3) and in rectangle", pointX, pointY);
        }
        else
        {
            Console.WriteLine("Point with coordinates x: {0} and y: {1} is out of the circle K((1,1),3) or out of rectangle", pointX, pointY);
        }
    }
}

