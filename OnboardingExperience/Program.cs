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

            newUser.FirstName = AskQuestion("Please Confirm your First Name.", true);
            // while (string.IsNullOrEmpty(newUser.FirstName))
            Console.WriteLine("Thanks your First Name is " + (newUser.FirstName));

            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();

            newUser.LastName = AskQuestion("Now please tell me your Last Name.", true);


            Console.WriteLine("Thanks your name is " + newUser.FirstName + " " + newUser.LastName);

            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();

            newUser.Age = AskAge("Now we just need to get your age", true);


            newUser.NameAge = ConfirmInfo($"Great we have your name as {newUser.FirstName} {newUser.LastName} and your age as {newUser.Age} is that correct?(yes/no).", true);


            newUser.PinNumber = AskUserPin("Now the last thing we need to get is set your PIN Number. Please enter what you would like as your personal Pin.", true);
            PressToContinue();

            newUser.NameAge = ConfirmInfo($"Fantastic now I just need to confirm this data before storing this information. Your name is {newUser.FirstName} {newUser.LastName} and your age is {newUser.Age} and the Pin we are saving is {newUser.PinNumber}?(yes/no)");


            Console.WriteLine("Thank you for using our app your updated information will now be set.");
            PressToContinue();
        }

        private static void PressToContinue()
        {
            Console.WriteLine("Press any key to continue.");
            Console.ReadKey(true);
        }

        private static bool ConfirmInfo(string question,bool required = false)
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

            private static int AskUserPin(string question, bool required = false, int lenght = 4)
        {
            while (true)
            {

                var reponse = AskQuestion(question);

                if (!int.TryParse(reponse, out var num))
                {
                    Console.WriteLine("Please write a number");
                    continue;
                }
                if(lenght > 0 && reponse.Length != lenght)
                {
                    Console.WriteLine($"Please enter a {lenght} digits exactly.");
                    continue;
                }

                return num;
            }

        }
    

        private static int AskAge(string question, bool required= false)
        {
            while(true)
            {

                var reponse = AskQuestion(question);

                if(!int.TryParse(reponse, out var num))
                {
                    Console.WriteLine("Please write a number");
                    continue;
                }

                return num;
            }

        }

        private static string AskQuestion(string question, bool required = false)
        {
            while (true)
            {
                Console.WriteLine(question);
                var answer = Console.ReadLine();

                if (required && string.IsNullOrEmpty(answer))
                {
                    Console.WriteLine("This answer is required");
                    continue;
                }

                return answer;
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
