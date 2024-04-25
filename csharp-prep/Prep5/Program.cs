using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep5 World!");

        DisplayWelcome();

        string userName = PromptUserName();

        int userNumber = PromptUserNumber();

        int squaredNumber = SquaredNumber(userNumber);

        DisplayResult(userName, squaredNumber);


    }
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }

    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        return Console.ReadLine();
    }

    static int PromptUserNumber()
    {
        Console.Write("What is your favourite number? ");
        string userinput = Console.ReadLine();

        if (int.TryParse(userinput, out int userNumber))
        {
            return userNumber;
        }
        else
        {
            Console.WriteLine("Invalid input. Default to 0 ");
            return 0;
        }

    }
    static int SquaredNumber(int number)
    {
        return number * number;
    }

    static void DisplayResult(string name, int squaredNumber)
    {
        Console.WriteLine($"Hello, {name}! Your favourite squared is {squaredNumber}");
    }


}
