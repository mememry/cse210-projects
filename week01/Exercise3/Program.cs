using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        bool continueGame = true;


        do
        {
            int magicNumber = randomGenerator.Next(1, 101);
            int guess = 0;
            int guessCount = 0;
            string input;

            Console.WriteLine("Guess a number between 1 and 100.");
            Console.WriteLine("Keep guessing until you get it right!");

            do
            {
                Console.Write("What is your guess? ");
                input = Console.ReadLine();
                guess = int.Parse(input);
                guessCount++;

                if (guess > magicNumber)
                {
                    Console.WriteLine("Lower");
                }
                else if (guess == magicNumber)
                {
                    Console.WriteLine("You guessed it!");
                }
                else
                {
                    Console.WriteLine("Higher");
                }
            } while (guess != magicNumber);
            Console.WriteLine($"You used {guessCount} guesses to get the magic number.");
            Console.Write("Do you want to play again? (y/n) ");
            input = Console.ReadLine();
            if (input != "n")
            {
                continueGame = true;
            }
            else
            {
                continueGame = false;
            }
        } while (continueGame == true);
        Console.WriteLine("Thank you for playing the game!");
    }
}