using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class RectangleArea
{
    static void Main()
    {
        string strOne = Console.ReadLine();
        double width = double.Parse(strOne);
        string strTwo = Console.ReadLine();
        double height = double.Parse(strTwo);

        double area = (width * height);

        Console.WriteLine("Rectangle Ares is: " + area);
    }
}

