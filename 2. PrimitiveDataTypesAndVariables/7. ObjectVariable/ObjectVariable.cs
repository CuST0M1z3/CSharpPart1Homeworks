using System;


class ObjectVariable
{
    static void Main()
    {

        string wordOne = "Hello";
        string wordTwo = "World";

        object concatThem = (wordOne + wordTwo);

        string initializeThem = (string)concatThem;

        Console.WriteLine(initializeThem);

    }
}

