using System;
using System.Runtime.ExceptionServices;

class Program
{
    static void Main(string[] args)
    {
        // Declare variables
        string firstName, lastName;

        // Ask for first name
        Console.WriteLine("What is your first name?");
        firstName = Console.ReadLine(); // Capture user input

        // Ask for last name
        Console.WriteLine("What is your last name?");
        lastName = Console.ReadLine(); // Capture user input

        // Output the result
        Console.WriteLine($"Your name is {lastName}, {firstName} {lastName}.");
    }
}