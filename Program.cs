using System;
using System.Text.RegularExpressions;

namespace UserRegistrationProblem
{
    public class Program
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
            Console.WriteLine("Enter the mobile number with country code in the beginning");
            string mobileNum = Console.ReadLine();
            Console.WriteLine("Enter the password");
            string password = null;
            while (true)
            {
                var key = System.Console.ReadKey(true);
                if (key.Key == ConsoleKey.Enter)
                    break;
                password += key.KeyChar;
            }
            Console.WriteLine(password);
        }
            public static bool ValidateFirstName(string firstName)
            {
                string nameRegexPattern = "[A-Z][a-z]{2,}";
                Regex nameRegex = new Regex(nameRegexPattern);
                if (nameRegex.IsMatch(firstName) && nameRegex.IsMatch("Kartikeya"))
                    return true;
                else
                return false;       
            }
        public static bool ValidateEmail(string email)
        {
            string emailRegexPattern = "^[a-zA-Z0-9]+([+-_.][a-zA-Z0-9]+)*[@][a-zA-Z0-9]+[.][a-zA-Z]+([.][a-zA-Z]{2})*$";
            Regex emailRegex = new Regex(emailRegexPattern);
            if (emailRegex.IsMatch("kartikeya.kumar@capgemini.com"))
                return true;
            else
                return false;
        }
        public static bool ValidateMobileNum(string email)
        {
            string mobileNumRegexPattern = "^[0-9]{2}[ ][0-9]{10}$";
            Regex mobileNumRegex = new Regex(mobileNumRegexPattern);
            if (mobileNumRegex.IsMatch("91 7206183244"))
                return true;
            else
                return false;
        }
        public static bool ValidatePassword(string email)
        {
            string passwordRegexPattern = "^(?=.*[A-Z])(?=.*[0-9])(?=.*[^0-9a-zA-Z])(?!.*[^0-9a-zA-Z].*[^0-9a-zA-Z]).{8,}$";
            Regex passwordRegex = new Regex(passwordRegexPattern);
            if (passwordRegex.IsMatch("Kartikeya@19"))
                return true;
            else
                return false;
        }
    }
}
