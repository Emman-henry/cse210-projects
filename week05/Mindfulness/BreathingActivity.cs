using System;
using System.Threading;

namespace ConsoleApp1
{
    // Inherited class from Starter
    public class BreathingActivity : Starter
    {
        // Constructor calling base class constructor with required arguments
        public BreathingActivity() : base(
            "Welcome to the breathing activity",
            "This activity will help you relax by guiding you through slow breathing.",
            "How long in seconds would you like to do this activity?",
            "Preparing to begin...",
            "Closing...")  // New closing message added here
        {
        }

        // Start method to handle the activity
        public void Start()
        {
            Console.WriteLine($"{Intro}");
            Console.WriteLine($"{Description}");
            Console.WriteLine($"{TimerPrompt}");

            string input = Console.ReadLine().Trim();
            int totalTime;

            // Validate the input time
            while (!int.TryParse(input, out totalTime) || totalTime <= 0)
            {
                Console.WriteLine("Please enter a valid positive number:");
                input = Console.ReadLine().Trim();
            }

            // Spinner animation using instance method
            Console.WriteLine($"\n{_checkingText}"); // Using the inherited field
            this.Spinners(); // Using the inherited method

            Console.WriteLine($"\nStarting your {totalTime}-second breathing session...\n");

            int elapsed = 0;

            // Perform breathing exercises (breathe in, breathe out)
            while (elapsed + 5 <= totalTime)
            {
                Console.WriteLine("\n🫁 Breathe in...");
                Countdown(5);
                elapsed += 5;

                if (elapsed + 5 > totalTime) break;

                Thread.Sleep(500); // Short pause between in and out

                Console.WriteLine("\n💨 Breathe out...");
                Countdown(5);
                elapsed += 5;

                Thread.Sleep(500); // Short pause
            }

            // Handle remaining seconds
            int remaining = totalTime - elapsed;
            if (remaining > 0)
            {
                Console.WriteLine($"\n🧘 Finish calmly for {remaining} more seconds...");
                Countdown(remaining);
            }

            // Display closing message and spinner again
            Console.WriteLine($"\n{_closingText}"); // Using the inherited closing field
            this.Spinners(); // Using the inherited method

            Console.WriteLine($"\n\n🎉 Done! You completed {totalTime} seconds of focused breathing.");
        }

        // Countdown method
        private void Countdown(int seconds)
        {
            for (int i = seconds; i > 0; i--)
            {
                string numStr = i.ToString();
                Console.Write(numStr);
                Thread.Sleep(1000);

                foreach (char _ in numStr)
                {
                    Console.Write("\b \b");
                }
            }
            Console.WriteLine(); // Line break
        }
    }
}
