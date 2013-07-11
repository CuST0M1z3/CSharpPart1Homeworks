using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class HowOldAreYou
{
    static void Main()
    {
        Console.WriteLine("Enter your year of birth:");
        string yearOfBirth = Console.ReadLine();
        int yearOfYourBirth = int.Parse(yearOfBirth);
        DateTime now = DateTime.Now;
        int yearNow = now.Year;
        int yourAge = 0;

        if (yearOfYourBirth > 0 && (yearOfYourBirth < yearNow))
        {
            yourAge = (yearNow - yearOfYourBirth);
        }
        else
        {
            Console.WriteLine("You enter a invalid year");
        }

        if (yourAge > 0 && yourAge < 101)
        {
            Console.WriteLine("After 10 years, you are: " + (yourAge + 10) + " years old");
        }
        else if (yourAge > 101)
        {
            Console.WriteLine("Probably you are death or a vampire :D");
        }
    }
}

