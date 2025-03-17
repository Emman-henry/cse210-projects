using System;

class Program
{
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program");
    }

    static string PromptUserName()
    {
        Console.WriteLine("What is your name?");
        string name = Console.ReadLine();
        return name;
    }

    static int PromptUserNumber()
    {
        Console.WriteLine("What is your favourite number?");
        int favouriteNumber = int.Parse(Console.ReadLine()); // Convert the input to an integer
        return favouriteNumber;
    }

    static int SquaredNumber(int favouriteNumber)
    {
        int squaredFav = favouriteNumber * favouriteNumber; // Calculate the square
        return squaredFav; // Return the squared value
    }

    static void DisplayResult(string name, int favNum)
    {
        Console.WriteLine($"{name}, the square of your number is {favNum}");
    }

    static void Main()
    {
        DisplayWelcome(); // Display welcome message

        // Get user's name and favorite number
        string userName = PromptUserName();
        int favNum = PromptUserNumber();

        // Get the square of the favorite number
        int squaredNum = SquaredNumber(favNum);

        // Display the result
        DisplayResult(userName, squaredNum);
    }
}
