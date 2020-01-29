using System;
using System.Text.RegularExpressions;


namespace LAB_7_Regular_Expression
{
    class Program
    {
        static void Main(string[] args)
        {
            bool wantToContinue = true;
            string continueEntry = null;
            bool validUserInput = false;

            //This program is checking is user enters the valid phone number
            while (wantToContinue)
            {
                wantToContinue = true;
                continueEntry = null;
                validUserInput = false;

                // Get user input and if the user input is invalid, ask again until user enters valid input
                while (!validUserInput)
                {
                    Console.WriteLine("Please enter your phone number (123-456-7890):");
                    var phoneNumber = (Console.ReadLine());

                    if (IsPhoneNumberValid(phoneNumber))
                    {
                        Console.WriteLine("Thank you for your phone number");
                        validUserInput = true;
                    }
                    else
                    {
                        Console.Write("Invalid entry, ");
                        validUserInput = false;
                    }
                }

                // After entering the phonr number ask user again if he / she wants to continue
                //with another phone number
                while (continueEntry != "y" && continueEntry != "n")
                {
                    Console.WriteLine("Would you like to enter another phone number (y/n)");
                    continueEntry = (Console.ReadLine().ToLower());


                    // check if user has entered correct input i.e.y or n; if not, ask user for another input
                    if (continueEntry == "y")
                    {
                        wantToContinue = true;

                    }
                    else if (continueEntry == "n")
                    {
                        wantToContinue = false;
                    }
                    else
                    {
                        Console.Write("Invalid Entry, ");
                    }

                }
            }
            Console.WriteLine("Thank you for your time, Goodbye!");
           


                       




            //This program checks if user enters the valid date format(dd/mm/yyyy)
            Console.WriteLine("Please enter a date in format of (dd/mm/yyyy):");
            string date = (Console.ReadLine());

            if (IsDateValid(date))
            {
                Console.WriteLine("Thank you for entering the date correctly.");
            }
            else
            {
                Console.WriteLine("Invalid entry, please enter valid date using (dd/mm/yyyy)");
                Console.ReadKey();
            }






            //This program checks if user enters the valid email format
            Console.WriteLine("Please enter an email address:");

            string email = (Console.ReadLine());


            if (IsValidEmail(email))
            {
                Console.WriteLine("Thank you for entering the email correctly.");
            }
            else
            {
                Console.WriteLine("Invalid entry, please enter valid email");
                Console.ReadKey();
            }







            //This program cheks if first name and last name entered correctly

            Console.WriteLine("Please enter name:");

            string name = (Console.ReadLine());

            if (IsFirstNameValid(name))
            {
                Console.WriteLine("Thank you for entering the name correctly.");
            }
            else
            {
                Console.WriteLine("Invalid entry, please enter valid name");
                Console.ReadKey();
            }
        }







        //This method checks if user enters the valid phone number(123-456-7890)
        public static bool IsPhoneNumberValid(string phoneNumber)
        {
            Regex rx = new Regex(@"^\d{ 3 } -\d{ 3}-\d{ 4}");

            return rx.IsMatch(phoneNumber);
        }









        //This method checks if user enters the valid date format(dd/mm/yyyy)
        public static bool IsDateValid(string name)
        {
            Regex rx = new Regex(@"^(0[1-9]|[12][0-9]|3[01])[- /.](0[1-9]|1[012])[- /.](19|20)\d\d$");

            return rx.IsMatch(name);
        }









        //This method checks if user enters the valid email format 
        public static bool IsValidEmail(string email)
        {

            Regex rx = new Regex(@"^[a-zA-Z0-9]{5,30}@(?:[a-zA-Z0-9]{5,10}\.)[a-zA-Z0-9]{2,3}$");

            return rx.IsMatch(email);
        }



        //This method cheks if user enters name in valid format
        public static bool IsFirstNameValid(string name)
        {
            Regex rx = new Regex(@"^[A-Z][a-z]{1,30}");

            return rx.IsMatch(name);
        }



    }
}
