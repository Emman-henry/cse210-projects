using System;
using System.Collections.Generic;
using System.Threading;

namespace ConsoleApp1
{
    public class ReflectingActivity : Starter
    {
        private List<string> prompts = new List<string>
        {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        };

        private List<string> questions = new List<string>
        {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
        };

        public ReflectingActivity() : base(
            "Welcome to the Reflecting Activity.",
            "This activity will help you reflect on times in your life when you have shown strength and resilience. " +
            "This will help you recognize the power you have and how you can use it in other aspects of your life.",
            "How long in seconds would you like to do this activity?",
            "Preparing to begin...",
            "Well done! You've completed the reflection activity.")
        {
        }

        public void Begin()
        {
            Console.WriteLine(Intro);
            Console.WriteLine(Description);
            Console.WriteLine(TimerPrompt);

            string input = Console.ReadLine().Trim();
            int totalTime;

            while (!int.TryParse(input, out totalTime) || totalTime <= 0)
            {
                Console.WriteLine("Please enter a valid positive number:");
                input = Console.ReadLine().Trim();
            }

            Console.WriteLine($"\n{_checkingText}");
            Spinners(); // Use inherited spinner

            Random rand = new Random();
            string selectedPrompt = prompts[rand.Next(prompts.Count)];

            Console.WriteLine($"\n🧠 Prompt: {selectedPrompt}");
            Console.WriteLine("Take a few seconds to think about this...\n");
            Spinners(); // Small pause before questions

            Console.WriteLine("\nNow consider the following questions:\n");

            int elapsed = 0;
            while (elapsed < totalTime)
            {
                string question = questions[rand.Next(questions.Count)];
                Console.WriteLine($"🔍 {question}");
                Spinners(); // Spinner acts as the pause
                elapsed += 5; // Each spinner lasts approx. 5 seconds
            }

            Console.WriteLine($"\n{_closingText}");
            Spinners();
            Console.WriteLine($"\n🎉 You completed {totalTime} seconds of reflection.");
        }
    }
}
