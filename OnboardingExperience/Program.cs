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
            N.LastName = Console.ReadLine();

            Console.WriteLine("Thanks your last name is " + (N.LastName));

            Console.WriteLine("Now we just need to get your age");
            N.Age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Great we have your age as " + (N.Age));

            // define if this is the account owner
            Console.WriteLine("Now we need to confrim that you are the account owner. Please rely y for 'yes' and n for 'no'");
            Console.ReadLine();
           

        }

    }
}
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
