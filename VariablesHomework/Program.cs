using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

namespace VariablesHomework
{
    internal class Program
    {
        // define user class here
        public class User
        {
            public string? Name { get; set; }
            public int Age { get; set; }
            public bool IsAlive { get; set; }
            public string? PhoneNumber { get; set; }
        }

        static void Main(string[] args)
        {
            User userProfile = new User();

            // opening/welcoming
            Console.WriteLine("Welcome, this console app simulates creating a user profile");
            Console.WriteLine("\nWe're going to start off with a couple of questions First");
            Console.WriteLine("------------------------------------------------------------");
            Console.ReadKey();

            // each portion will...
            // 1. prompt a user for some input with a consolewriteline
            // 2. validate the users input
            // a. if validation fails give user more information on why
            // b. on success store the data inside a user class

            //name
            // string variable name
            // shouldn't contain numbers or non alphabet characters

            // Prompt for name
            Console.WriteLine("First may I have your full name");
            string? name = Console.ReadLine();


            if (name.Split(" ").Length < 2) 
            {
                Console.WriteLine("Only one name was provided, please try again and provide both first and last names");
                Console.ReadKey();
                return;
            }

            if (name.Any(char.IsDigit))
            {
                Console.WriteLine("Please avoid from using any non alphabetic characters");
                Console.ReadKey();
                return;
            }


            //age
            // int variable age
            // only acceptable values are 1 through 110

            // Prompt for age
            Console.WriteLine("Next please tell me your age");
            string? stringAge = Console.ReadLine();

            if(Int32.TryParse(stringAge, out int age))
            {
                Console.WriteLine("Please provide a numeric character between 1 through 110");
                Console.ReadKey();
                return;
            }

            if (age < 1 || age > 110) 
            {
                Console.WriteLine("Please provide a numeric character between 1 through 110");
                Console.ReadKey();
                return;
            }

            userProfile.Age = age;

            //if they are alive
            // simple Boolean store

            //and their phone Number
            // string variable 
            // should only contain numbers, dashes, and parenthesis 
            // should be (123) 123-1234
            // will store phone number already formatted, or will format the number from user input
            // regex removes non numeric characters "[^0-9.]"
        }
    }
}
