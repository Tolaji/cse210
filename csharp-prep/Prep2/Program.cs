using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");

        Console.Write("What is your first name? ");
        string firstname = Console.ReadLine();

        Console.Write("What is your last name? ");
        string lastname = Console.ReadLine();

        Console.WriteLine($"Your name is {lastname}, {firstname} {lastname}.");

        // Prompt user to provide score
        Console.Write("What is your score percentage?  ");
        string scoreString = Console.ReadLine();

        // Convert the user input to an integer as: If conversion successful, use 'result'
        if (int.TryParse(scoreString, out int score))
        {
            string letter;

            if (score >= 90)
            {
                letter = "A";
            }
            else if (score >= 80)
            {
                letter = "B";
            }
            else if (score >= 70)
            {
                letter = "C";
            }
            else if (score >= 60)
            {
                letter = "D";
            }
            else
            {
                letter = "F";
            }

            Console.WriteLine($"Your Score: {score}, Your grade: {letter}\n");
            {
                if (letter == "A" || letter == "B" || letter == "C")
                {
                    Console.WriteLine("Congratulations! You have passed the course");
                }
                else
                {
                    Console.WriteLine("Am sorry, I know you tried hard, but you have to try harder next time");
                }

            }
        }
        else
        // Handle exception error in the case that the input is not a valid integer
        {
            Console.WriteLine("Invalid input. Please enter a valid integer for the score.");
        }
    }
}


