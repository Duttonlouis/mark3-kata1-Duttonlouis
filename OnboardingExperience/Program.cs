using System;

namespace OnboardingExperience
{
    class Program
    {
        static void Main(string[] args)
        {
            var N = new User();

            Console.WriteLine("Hello thank you for using our app to get started i need some information from you.");

            Console.WriteLine("Please tell me your first name.");
            N.FirstName = Console.ReadLine();

            Console.WriteLine("Thanks your first name is " + (N.FirstName));

            Console.WriteLine("Now please tell me your last name.");
            var lastName = Console.ReadLine();

            Console.WriteLine("Thanks your last name is " + (lastName));

            Console.WriteLine("Now we just need to get your age");
            var Age = Console.ReadLine();
                      

            
            /*
            var response = Console.ReadLine();

            if (response == "" || response == " ")
            {
                Console.WriteLine("Must have valid input");
            }
            else
            {
                return reponse;
            }
            */

        }


    }
}
