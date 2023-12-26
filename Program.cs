using System;

namespace NumberGuessingGame
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Number Guessing Game!");
            Console.WriteLine("I'm thinking of a number between 1 and 100. Can you guess it?");

            Random random = new Random();
            int secretNumber = random.Next(1, 101); // Generate a random number between 1 and 100

            int guessCount = 0;
            bool guessedCorrectly = false;

            while (!guessedCorrectly)
            {
                Console.Write("Enter your guess: ");
                int guess = int.Parse(Console.ReadLine());

                guessCount++;

                if (guess == secretNumber)
                {
                    Console.WriteLine("Congratulations! You guessed the number in {0} tries!", guessCount);
                    guessedCorrectly = true;
                }
                else if (guess < secretNumber)
                {
                    Console.WriteLine("Too low! Guess higher.");
                }
                else
                {
                    Console.WriteLine("Too high! Guess lower.");
                }
            }
        }
    }
}