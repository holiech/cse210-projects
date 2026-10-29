using System;

class Program
{
    static void Main()
    {
        Random random = new Random();
        int magicNumber = random.Next(1, 101); // Generate a random
        int userGuess;
        int guessCount = 0;

        Console.WriteLine("Welcome to the Guess My Number game!");
        
        do
        {
            Console.Write("What is your guess? ");
            userGuess = int.Parse(Console.ReadLine());
            guessCount++;

            if (userGuess < magicNumber)
            {
                Console.WriteLine("Higher");
            }
            else if (userGuess > magicNumber)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guessed it!");
                Console.WriteLine($"It took you {guessCount} guesses to find the magic number.");
                Console.Write("Do you want to play again? (yes/no): ");
                string playAgain = Console.ReadLine().ToLower();
                
                if (playAgain != "yes")
                {
                    break;
                }
                else
                {
                    magicNumber = random.Next(1, 101);
                    guessCount = 0;
                }
            }
        } while (true);
    }
}