using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class PrimeNumbers
{
    static void Main()
    {
        string str = Console.ReadLine();
        int number = int.Parse(str);

        if ((number > 1) && (number <= 100)) {
	            if (number == 2 || number == 3 || number == 5 || number == 7) {
                    Console.WriteLine("The number " + number + " is prime");
	            }
	            else {
	                if (number % 2 == 0 || number % 3 == 0 || number % 4 == 0 || number % 5 == 0 || number % 6 == 0 || number % 7 == 0 || number % 8 == 0 || number % 9 == 0 || number % 10 == 0) {

                        Console.WriteLine("The number " + number + " is not prime");
	                }
	                else {
                        Console.WriteLine("The number " + number + " is prime");
	                }
	            }

	        }
	        else {
                Console.WriteLine("Number is out of range");
	        }
    }
}

