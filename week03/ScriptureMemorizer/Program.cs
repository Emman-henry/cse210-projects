using System;

class Program
{
    static void Main(string[] args)
    {
        // Start by getting a random scripture using the static method
        Scripture scripture = Scripture.GetNewScripture(); 

        int wordsToHide = 5; // Starting with 5 words to hide

        // Main loop for user interaction
        while (true)
        {
            scripture.DisplayScripture();  // Display current state of scripture

            // Prompt user for action
            Console.WriteLine("\nPress Enter to hide more words or type 'quit' to exit.");

            string input = Console.ReadLine().Trim().ToLower();

            if (input == "quit")
            {
                Console.WriteLine("\nDo you want to try another scripture? yes/no");
                string option = Console.ReadLine().Trim().ToLower();

                if (option == "yes") 
                {
                    // Correctly calling the static method here
                    scripture = Scripture.GetNewScripture();  // Get a new random scripture
                }
                else
                {
                    break; // Exit the program
                }
            }

            if (input == "")
            {
                scripture.HideWords(wordsToHide);  // Hide words based on current number
                wordsToHide = Math.Max(wordsToHide - 1, 1);  // Decrease the number of words to hide, but at least 1
            }
        }

        // Final message
        Console.WriteLine("Scripture memorization complete. Goodbye!");
    }
}
