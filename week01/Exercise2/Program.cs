using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter your grade percentage? ");
        string valueFromUser = Console.ReadLine();

        if (int.TryParse(valueFromUser, out int grade))
        {
            string letter;

            if (grade >= 90)
            {
                letter = "A";
            }
            else if (grade >= 80)
            {
                letter = "B";
            }
            else if (grade >= 70)
            {
                letter = "C";
            }
            else if (grade >= 60)
            {
                letter = "D";
            }
            else
            {
                letter = "F";
            }

            Console.WriteLine($"Your letter grade is: {letter}");

            if (grade >= 70)
            {
                Console.WriteLine("Congratulations! You passed the course.");
            }
            else
            {
                Console.WriteLine("Don't give up! Study hard and you'll do better next time.");
            }
        }
        else
        //I added this else statement to help with wrong input
        {
            Console.WriteLine("Invalid input. Please enter a numeric value.");
        }

    }
}