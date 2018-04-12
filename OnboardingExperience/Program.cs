using System;

namespace OnboardingExperience
{
    class Program
    {
        static void Main(string[] args)
        {
            var N = new User();
            bool IsUser = false;
            string answer;
            // define if this is the account owner

            Console.WriteLine("Hi welcome to the First Grand Bank are you an account owner. Type (yes/no)");
            answer = Console.ReadLine().ToLower();
            answer.Trim();

            if (answer == "yes")
            {
                IsUser = true;
                Console.WriteLine("Great it's good to see you again");
            }
            while ( answer != "yes")
            {
                Console.WriteLine("Sorry but this is for account users only");
                return;
            }
            
            
            Console.WriteLine("Thank you for using our app to get started I update some information from you.");

            Console.WriteLine("Please tell me your first name.");
            N.FirstName = Console.ReadLine();


            Console.WriteLine("Thanks your first name is " + (N.FirstName));

            Console.WriteLine("Now please tell me your last name.");
            N.LastName = Console.ReadLine();

            Console.WriteLine("Thanks your last name is " + (N.LastName));

            Console.WriteLine("Now we just need to get your age");
            N.Age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Great we have your age as " + (N.Age));

           
            

           

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
