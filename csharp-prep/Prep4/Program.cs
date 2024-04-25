using System;


using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep4 World!");
        
        List<int> numbers = new List<int>();

        int userNumber;

        do
        {
            Console.Write("Enter a number (0 to quit): ");
            string userResponse = Console.ReadLine();

            // Try to parse user input, if unsuccessful set userNumber to 0
            if (!int.TryParse(userResponse, out userNumber))
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
                userNumber = 0; // Set to 0 to ensure loop continues
            }
            else if (userNumber != 0)
            {
                numbers.Add(userNumber);
            }

        } while (userNumber != 0);

        // Part 1: Compute the sum
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }

        Console.WriteLine($"The sum is: {sum}");

        // Part 2: Compute the average
        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is: {average}");

        // Part 3: Find the max
        int max = numbers.Count > 0 ? numbers[0] : 0;

        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }

        Console.WriteLine($"The max is: {max}");
    }
}