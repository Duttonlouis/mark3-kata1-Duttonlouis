using System;

namespace OnboardingExperience
{
    class Program
    {
        static void Main(string[] args)
        {
            string answer;
            // define if this is the account owner

            Console.WriteLine("Hi welcome to the First Grand Bank are you an account owner. Type (yes/no)");
            

            bool IsUser = false;
            while (true)
            {
                answer = Console.ReadLine().ToLower();
                answer.Trim();
                if (answer == "yes")
                {
                    IsUser = true;
                    Console.WriteLine("Great get started.");
                }
                if (answer != "yes")
                {
                    Console.WriteLine("Would you like to be?");

                }
                else break;
            }
            

        
            
            Console.WriteLine("Thank you for using our app to get started I need to update some information for you.");

            Console.WriteLine("Please Confirm your First Name.");
            var N = new User();
            while (true)
            {
                N.FirstName = Console.ReadLine().ToUpper();
                N.FirstName.Trim();

                // if folder name is null 
                if (string.IsNullOrEmpty(N.FirstName) || string.IsNullOrWhiteSpace(N.FirstName))
                {
                    Console.WriteLine("I am sorry please add your Frist name. Please enter your name.");
                    //(Can't be null)
                }
                else // Name is valid
                    break;
            }

            Console.WriteLine("Thanks your First Name is " + (N.FirstName));

            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();

            Console.WriteLine("Now please tell me your Last Name.");

            while (true)
            {
                N.LastName = Console.ReadLine().ToUpper();
                N.LastName.Trim();

                // if folder name is null or empty or whitespace
                if (string.IsNullOrEmpty(N.LastName) || string.IsNullOrWhiteSpace(N.LastName))
                {
                    Console.WriteLine("I am sorry please add your Last name. Please enter your name.");
                    //(Can't be null)
                }
                else // Name is valid
                    break; 
            }
            
           

            Console.WriteLine("Thanks your name is " + N.FirstName + " " +N.LastName);

            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();

            Console.WriteLine("Now we just need to get your age");
            N.Age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Great we have your name as {0} {1} and your age as {2} is that correct?(yes/no).", N.FirstName, N.LastName, N.Age);
            string CAnswer = Console.ReadLine().ToLower();
            CAnswer.Trim();

            if (CAnswer == "yes")
            {
                Console.WriteLine("Great we are almost done gathering what we need.");
            }
            while (CAnswer != "yes")
            {
                Console.WriteLine("I am sorry but this is information doesn't seem right");
                return;
            }
            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();

            Console.WriteLine("Now the last thing we need to get is set your PIN Number. Please enter what you would like as your personal Pin.");
            N.PinNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();

            Console.WriteLine("Fantastic now I just need to confirm this data before storing this information. Your name is {0} {1} and your age is {2} and the Pin we are saving is {3}?(yes/no)", N.FirstName, N.LastName, N.Age, N.PinNumber);
            string CAnswer1 = Console.ReadLine().ToLower();
            CAnswer1.Trim();

            if (CAnswer1 == "yes")
            {
                IsUser = true;
                Console.WriteLine("Thank you for using our app your updated information will now be set.");
            }
            while (CAnswer1 != "yes")
            {
                Console.WriteLine("I am sorry but this is information doesn't seem right");
                return;
            }






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
