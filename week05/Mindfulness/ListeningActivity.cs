using System;
using System.Collections.Generic;
using System.Threading;

namespace ConsoleApp1
{
    public class ListingActivity : Starter
    {
        private List<string> prompts = new List<string>
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };

        public ListingActivity() : base(
            "Welcome to the Listing activity.",
            "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.",
            "How long in seconds would you like to do this activity?",
            "Preparing to begin...",
            "Closing the Listing activity..."
        ) { }

        public void Start()
        {
            Console.WriteLine($"{Intro}");
            Console.WriteLine($"{Description}");
            Console.WriteLine($"{TimerPrompt}");

            string input = Console.ReadLine().Trim();
            int totalTime;

            while (!int.TryParse(input, out totalTime) || totalTime <= 0)
            {
                Console.WriteLine("Please enter a valid positive number:");
                input = Console.ReadLine().Trim();
            }

            Console.WriteLine($"\n{_checkingText}");
            Spinners();

            Random rand = new Random();
            string selectedPrompt = prompts[rand.Next(prompts.Count)];

            Console.WriteLine($"\n📝 Prompt: {selectedPrompt}");
            Console.WriteLine("You will begin listing items shortly...");
            ShowCountdown(5); // countdown before starting listing

            Console.WriteLine("\nStart listing! Type each item and press Enter:");

            DateTime startTime = DateTime.Now;
            DateTime endTime = startTime.AddSeconds(totalTime);
            List<string> responses = new List<string>();

            while (DateTime.Now < endTime)
            {
                if (Console.KeyAvailable)
                {
                    string response = Console.ReadLine();
                    if (!string.IsNullOrWhiteSpace(response))
                    {
                        responses.Add(response);
                    }
                }
            }

            Console.WriteLine($"\n🎉 Time’s up! You listed {responses.Count} item(s).");
            Console.WriteLine($"{_closingText}");
            Spinners();
        }

        private void ShowCountdown(int seconds)
        {
            for (int i = seconds; i > 0; i--)
            {
                Console.Write($"\rStarting in {i}...");
                Thread.Sleep(1000);
            }
            Console.WriteLine("\rLet's go!            ");
        }
    }
}