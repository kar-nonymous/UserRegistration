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
            Console.WriteLine("Enter the lat name ");
            string firstName = Console.ReadLine();
            string lastName = Console.ReadLine();
            string regexPattern = "[A-Z][a-z]{2,}";
        
            Regex regex = new Regex(regexPattern);
           
            if (regex.IsMatch(firstName) && regex.IsMatch(lastName))
                Console.WriteLine("Name entered is valid");
            else
                Console.WriteLine("Name entered is invalid");

        }
    }
}
