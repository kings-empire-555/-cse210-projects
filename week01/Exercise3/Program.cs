using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101); // Generate a random number between 1 and 100

        int userGuess = -1;
        int attempts = 0;

        Console.WriteLine("Welcome to the Guessing Game!");
        Console.WriteLine("Try to guess the number between 1 and 100.");

        while (userGuess != magicNumber)
        {
            Console.Write("Enter your guess: ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out userGuess))
            {
                attempts++; // Increment attempt count

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
                    Console.WriteLine($"You guessed it in {attempts} attempts! Good Job!");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please input a valid number."); // Handle invalid input
            }
        }
    }
}
