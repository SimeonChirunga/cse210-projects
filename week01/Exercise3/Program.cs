using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise3 Project.");
        System.Console.WriteLine();
        System.Console.WriteLine("I think of a number between 1 and 100, try to guess it.");
        string playAgain = "Yes";
        do
            {
                Random randomGenerator = new Random();
                int number = randomGenerator.Next(1, 100);
                int guess = 10000;
                int numberOfGuesses = 0;
                
        
        
                do
                    {
                        System.Console.Write("What is your guess? ");
                        string guessNumber = Console.ReadLine();
                        guess = int.Parse(guessNumber);
                        numberOfGuesses++;
                        if (number > guess)
                        {
                            System.Console.WriteLine("Higher");
                        }
                        else if (number < guess)
                        {
                            System.Console.WriteLine("Lower");
                        }
                        else
                        {
                            System.Console.WriteLine("You guessed it!");
                        }
                } while (number != guess);
                System.Console.WriteLine($"You got it after {numberOfGuesses} trials");
                System.Console.Write("Do you want to play again? (Yes or No)");
                playAgain = Console.ReadLine();

            } while (playAgain == "Yes");



    }
}