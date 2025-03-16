using System;

class Program
{
    static void Main(string[] args)
    {
        // Create a random number generator
        Random random = new Random();
        
        // Generate a magic number between 1 and 100
        int magic_number = random.Next(1, 101);
        
        Console.WriteLine("What is your guess?");

        // Read the user's guess
        int guess = int.Parse(Console.ReadLine());
        
        // Loop until the user guesses the correct number
        while (guess != magic_number)
        {
            // Check the guess
            if (guess > magic_number)
            {
                Console.WriteLine("Lower");
            }
            else if (guess < magic_number)
            {
                Console.WriteLine("Higher");
            }

            // Ask the user to guess again
            Console.WriteLine("Try again! What is your guess?");
            guess = int.Parse(Console.ReadLine());
        }
        
        // When the user guesses correctly
        Console.WriteLine("You just got the magic number!");
    }
}
