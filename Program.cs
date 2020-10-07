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
            

            string nameRegexPattern = "[A-Z][a-z]{2,}";
            string emailRegexPattern = "^[a-zA-Z0-9]+([+-_.][a-zA-Z0-9]+)*[@][a-zA-Z0-9]+[.][a-zA-Z]+([.][a-zA-Z]{2})*$";
            string mobileNumRegexPattern = "^[0-9]{2}[ ][0-9]{10}$";
            string passwordRegexPattern = "^(?=.*[A-Z])(?=.*[0-9])(?=.*[^0-9a-zA-Z])(?!.*[^0-9a-zA-Z].*[^0-9a-zA-Z]).{8,}$";

            Regex nameRegex = new Regex(nameRegexPattern);
            Regex emailRegex = new Regex(emailRegexPattern);
            Regex mobileNumRegex = new Regex(mobileNumRegexPattern);
            Regex passwordRegex = new Regex(passwordRegexPattern);

            if (nameRegex.IsMatch(firstName) && nameRegex.IsMatch(lastName))
                Console.WriteLine("Name entered is valid");
            else
                Console.WriteLine("Name entered is invalid");
            if (emailRegex.IsMatch(email))
                Console.WriteLine("The entered email is valid");
            else
                Console.WriteLine("The entered email is invalid");
            if (mobileNumRegex.IsMatch(mobileNum))
                Console.WriteLine("The entered mobile number is valid");
            else
                Console.WriteLine("The entered mobile number is invalid");
            if (passwordRegex.IsMatch(password))
                Console.WriteLine("The password is valid");
            else
                Console.WriteLine("The password is invalid");

            string patternOfEmail = "^[a-zA-Z0-9]+([.+_-][a-zA-Z0-9]+)*@[a-zA-Z0-9]+[.][a-zA-Z]+([.][a-zA-Z]{2})?$";
            string[] sampleEmail = {"abc@yahoo.com","abc-100@yahoo.com","abc.100@yahoo.com","abc111@abc.com","abc-100@abc.net","abc.100@abc.com.au",
                                    "abc@1.com","abc@gmail.com.com","abc+100@gmail.com","Abc","abc@.com.my" ,"abc123@gmail.1a","abc123@.com","abc123@.com.com",".abc@abc.com","abc()*@gmail.com","abc@%*.com","abc..2002@gmail.com","abc.@gmail.com","abc@abc@gmail.com","abc@gmail.com.1a","abc@gmail.com.aa.au"};
            Console.WriteLine("The valid sample emails are :");
            foreach (string sample in sampleEmail)
            {
                if (Regex.IsMatch(sample, patternOfEmail))
                    Console.WriteLine(sample);

            }

        }
    }
}
