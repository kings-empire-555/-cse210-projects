using System.Collections.Generic;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int userNumber = -1;

        // Prompt user to enter number
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        // Read user input
        while (true)
        {
            Console.Write("Enter number: ");
            userNumber = int.Parse(Console.ReadLine());

            if (userNumber == 0)
            {
                break;
            }

            numbers.Add(userNumber);
        }

        // Calculate sum, average, and largest number
        int sum = 0;
        int largest = int.MinValue;

        foreach (var number in numbers)
        {
            sum += number;
            if (number > largest)
            {
                largest = number;
            }
        }

        double average = numbers.Count > 0 ? (double)sum / numbers.Count : 0;
        {
            Console.WriteLine($"The sum is: {sum}");
            Console.WriteLine($"The average is: {average}");
            Console.WriteLine($"The largest number is: {largest}");
        }
    }

}