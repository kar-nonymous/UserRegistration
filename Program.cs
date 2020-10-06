using System;
using System.Text.RegularExpressions;

namespace UserRegistrationProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to user registration problem");
            Console.WriteLine("Enter the first name ");
            string firstName = Console.ReadLine();
            Console.WriteLine("Enter the lat name ");
            string lastName = Console.ReadLine();
            Console.WriteLine("Enter the email id");
            string email = Console.ReadLine();
            string nameRegexPattern = "[A-Z][a-z]{2,}";
            string emailRegexPattern = "^[a-zA-Z0-9]+([+-_.][a-zA-Z0-9]+)*[@][a-zA-Z0-9]+[.][a-zA-Z]+([.][a-zA-Z]{2})*$";


            Regex nameRegex = new Regex(nameRegexPattern);
            Regex emailRegex = new Regex(emailRegexPattern);
            if (nameRegex.IsMatch(firstName) && nameRegex.IsMatch(lastName))
                Console.WriteLine("Name entered is valid");
            else
                Console.WriteLine("Name entered is invalid");
            if (emailRegex.IsMatch(email))
                Console.WriteLine("The entered email is valid");
            else
                Console.WriteLine("The entered email is invalid");

        }
    }
}
