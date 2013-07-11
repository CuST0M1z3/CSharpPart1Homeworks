using System;

class NullableVariables
{
    static void Main()
    {
        int? a = null;
        double? b = null;

        Console.WriteLine(a);
        Console.WriteLine(b);

        a += null;

        Console.WriteLine(a);

        b += 1.2556;

        Console.WriteLine(b);

    }
}

