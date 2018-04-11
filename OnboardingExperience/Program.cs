using System;

namespace OnboardingExperience
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello thank you for using our app to get started i need some information from you.");
            Console.WriteLine("Please tell me your first name.");
            var firstName = Console.ReadLine();

            Console.WriteLine("Thanks your first name is " + (firstName));

            Console.WriteLine("Now please tell me your last name.");
            var lastName = Console.ReadLine();

            Console.WriteLine("Thanks your last name is " + (lastName));






        }
    }
}
