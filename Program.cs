using System;

namespace Lab03
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isBadNumber;
            bool playAgain = true;
            int number = -1;

            Console.WriteLine("Hi! What's your name?");
            string userName = Console.ReadLine();

            do // loop for play again
            {
                isBadNumber = true;
                while (isBadNumber == true)
                {
                    Console.WriteLine($"{userName}, please enter a whole number between 1 and 100.");
                    string userInput = Console.ReadLine();

                    if (!int.TryParse(userInput, out number))
                    {
                        Console.WriteLine($"Sorry, no decimals or non-number characters please.");
                    }
                    else if (number < 1 || number > 100)
                    {
                        Console.WriteLine($"Sorry, that number was out of range.");
                    }
                    else
                    {
                        isBadNumber = false;
                    }
                }

                Console.WriteLine(NumberSorter(number));

                bool isValidYesNo = false;
                do // loop while getting a valid playAgain input
                {
                    Console.WriteLine("Continue? (y/n)");
                    string input = Console.ReadLine();
                    if (input.Trim().ToLower() == "n")
                    {
                        playAgain = false;
                        isValidYesNo = true;
                    }
                    else if (input.Trim().ToLower() == "y")
                    {
                        isValidYesNo = true;
                    } else
                    {
                        Console.WriteLine($"Please just enter a 'y' or an 'n', {userName}.");
                    }
                } while (isValidYesNo == false);


            } while (playAgain == true);

            Console.WriteLine($"Thanks for playing, {userName}! Press any key to exit.");
            Console.ReadKey();
        }

        public static string NumberSorter(int number)
        {
            if (number % 2 != 0)
            {
                return $"{number} and Odd.";
            }
            else if (number % 2 == 0 && number >= 2 && number <= 25)
            {
                return $"Even and less than 25.";
            }
            else if (number % 2 == 0 && number >= 26 && number <= 60)
            {
                return $"Even.";
            }
            else if (number % 2 == 0 && number >= 60)
            {
                return $"{number} and Even.";
            }
            else if (number % 2 != 0 && number >= 60)
            {
                return $"{number} and Odd.";
            }
            else
            {
                return "Error.";
            }
        }
    }
}