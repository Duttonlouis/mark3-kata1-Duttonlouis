using System;

namespace OnboardingExperience
{
    class Program
    {
        static void Main(string[] args)
        {
            var newUser = new User();
            // define if this is the account owner

            newUser.IsAccountOwner = AskBoolQuestion("Hi welcome to the First Grand Bank. Are you an account owner? Type (yes/no)");

            if (!newUser.IsAccountOwner)
            {
                Console.WriteLine("Thank you for trying our app");
                Environment.Exit(-1);
            }


            Console.WriteLine("Thank you for using our app to get started I need to update some information for you.");

            Console.WriteLine("Please Confirm your First Name.");

            // while (string.IsNullOrEmpty(newUser.FirstName))

            while (true)
            {
                newUser.FirstName = Console.ReadLine().ToUpper();
                newUser.FirstName.Trim();

                // if folder name is null 
                if (string.IsNullOrEmpty(newUser.FirstName) || string.IsNullOrWhiteSpace(newUser.FirstName))
                {
                    Console.WriteLine("I am sorry please add your Frist name. Please enter your name.");
                    //(Can't be null)
                }
                else // Name is valid
                    break;
            }

            Console.WriteLine("Thanks your First Name is " + (newUser.FirstName));

            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();

            Console.WriteLine("Now please tell me your Last Name.");

            while (true)
            {
                newUser.LastName = Console.ReadLine().ToUpper();
                newUser.LastName.Trim();

                // if folder name is null or empty or whitespace
                if (string.IsNullOrEmpty(newUser.LastName) || string.IsNullOrWhiteSpace(newUser.LastName))
                {
                    Console.WriteLine("I am sorry please add your Last name. Please enter your name.");
                    //(Can't be null)
                }
                else // Name is valid
                    break;
            }



            Console.WriteLine("Thanks your name is " + newUser.FirstName + " " + newUser.LastName);

            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();

            Console.WriteLine("Now we just need to get your age");
            newUser.Age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Great we have your name as {0} {1} and your age as {2} is that correct?(yes/no).", newUser.FirstName, newUser.LastName, newUser.Age);
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
            newUser.PinNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();

            Console.WriteLine("Fantastic now I just need to confirm this data before storing this information. Your name is {0} {1} and your age is {2} and the Pin we are saving is {3}?(yes/no)", newUser.FirstName, newUser.LastName, newUser.Age, newUser.PinNumber);
            string CAnswer1 = Console.ReadLine().ToLower();
            CAnswer1.Trim();

            if (CAnswer1 == "yes")
            {
                
                Console.WriteLine("Thank you for using our app your updated information will now be set.");
            }
            while (CAnswer1 != "yes")
            {
                Console.WriteLine("I am sorry but this is information doesn't seem right");
                return;
            }
        }

        static bool AskBoolQuestion(string question)
        {
            while (true)
            {
                Console.WriteLine(question);
                var response = Console.ReadLine().ToLower().Trim();

                if (response.Contains("yes") || response.Contains("Yes"))
                {
                    return true;
                }
                else if (response.Contains("no") || response.Contains("No"))
                {
                    return false;
                }

                Console.WriteLine("You must answer yes or no");
            }
        }
        
    }

}
