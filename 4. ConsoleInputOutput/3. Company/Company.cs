using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Company
{
    static void Main()
    {
        Console.WriteLine("Enter Company Name:");
        string companyName = Console.ReadLine();
        Console.WriteLine("Enter Company Address:");
        string companyAddress = Console.ReadLine();
        Console.WriteLine("Enter Company phone:");
        string strPhone = Console.ReadLine();
        int phoneNumber = int.Parse(strPhone);
        Console.WriteLine("Enter Company Fax:");
        string strFax = Console.ReadLine();
        int faxNumber = int.Parse(strFax);
        Console.WriteLine("Enter Company website:");
        string webSite = Console.ReadLine();
        Console.WriteLine("Enter Manager First Name:");
        string managerFirstName = Console.ReadLine();
        Console.WriteLine("Enter Manager Last Name:");
        string managerLastName = Console.ReadLine();
        Console.WriteLine("Enter Manager Age:");
        string strAge = Console.ReadLine();
        int age = int.Parse(strAge);
        Console.WriteLine("Enter Manager phone number:");
        string strPhoneNumber = Console.ReadLine();
        int managerPhoneNumber = int.Parse(strPhoneNumber);

        Console.WriteLine("Company name is: {0}, his address is: {1}", companyName, companyAddress);
        Console.WriteLine("Company phone number is: {0}, and fax number is: {1}", strPhone, strFax);
        Console.WriteLine("Company website is: " + webSite);
        Console.WriteLine("Manager name is: {0} {1}, and he is {2} years old, and his phone numbers is: {3}", managerFirstName, managerLastName, age, managerPhoneNumber);
    }
}

