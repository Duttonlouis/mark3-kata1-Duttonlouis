using System;

namespace OnboardingExperience
{
    class Program
    {
        static void Main(string[] args)
        {
            var newUser = new User();

            newUser.IsAccountOwner = AskBoolQuestion("Hi welcome to the First Grand Bank. Are you an account owner? Type (yes/no)");

            if (!newUser.IsAccountOwner)
            {
                Console.WriteLine("Thank you for trying our app");
                return;
            }

            Console.WriteLine("Thank you for using our app to get started I need to update some information for you.");

            newUser.FirstName = AskQuestion("Please Confirm your First Name.", true);
            Console.WriteLine("Thanks your First Name is " + (newUser.FirstName));
            PressToContinue();

            newUser.LastName = AskQuestion("Now please tell me your Last Name.", true);
            Console.WriteLine("Thanks your name is " + newUser.FirstName + " " + newUser.LastName);
            PressToContinue();

            newUser.Age = AskIntQuestion("Now we just need to get your age");
            newUser.NameAge = AskBoolQuestion($"Great we have your name as {newUser.FirstName} {newUser.LastName} and your age as {newUser.Age} is that correct?(yes/no).");

            newUser.PinNumber = AskIntQuestion("Now the last thing we need to get is set your PIN Number. Please enter what you would like as your personal Pin.", 4);
            PressToContinue();

            var isConfirmed = AskBoolQuestion($"Fantastic now I just need to confirm this data before storing this information. Your name is {newUser.FirstName} {newUser.LastName} and your age is {newUser.Age} and the Pin we are saving is {newUser.PinNumber}?(yes/no)");

            if (isConfirmed)
            {
                Console.WriteLine("Thank you for using our app your updated information will now be set.");
            }
            else
            {
                Console.WriteLine("Well, that sucks");
            }
        }

        private static void PressToContinue()
        {
            Console.WriteLine("Press any key to continue.");
            Console.ReadKey(true);
        }

        private static int AskIntQuestion(string question, int length = 0)
        {
            while (true)
            {
                var reponse = AskQuestion(question);

                if (!int.TryParse(reponse, out var num))
                {
                    Console.WriteLine("Please write a number");
                    continue;
                }

                if (length > 0 && reponse.Length != length)
                {
                    Console.WriteLine($"Please enter a {length} digits exactly.");
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
