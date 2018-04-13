using System;
using System.Collections.Generic;
using System.Text;

namespace OnboardingExperience
{
    class User
    {
        public bool IsAccountOwner { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public bool NameAge { get; set; }

        public int Age { get; set; }

        public int PinNumber { get; set; }

        private static void PressToContinue()
        {
            Console.WriteLine("Press any key to continue.");
            Console.ReadKey(true);
        }

        private static bool ConfirmInfo(string question, bool required = false)
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
                if (lenght > 0 && reponse.Length != lenght)
                {
                    Console.WriteLine($"Please enter a {lenght} digits exactly.");
                    continue;
                }

                return num;
            }

        }

        private static int AskAge(string question, bool required = false)
        {
            while (true)
            {

                var reponse = AskQuestion(question);

                if (!int.TryParse(reponse, out var num))
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
