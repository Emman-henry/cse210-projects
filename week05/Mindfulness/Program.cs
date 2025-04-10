using System;
using System.Threading;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("\nMenu options:");
                Console.WriteLine("1. Start breathing activity");
                Console.WriteLine("2. Start reflecting activity");
                Console.WriteLine("3. Start listening activity");
                Console.WriteLine("4. Quit");

                string input = Console.ReadLine().Trim().ToLower();

                switch (input)
                {
                    case "1":
                        BreathingActivity breathing = new BreathingActivity();
                        breathing.Start();
                        break;
                    case "2":
                        ReflectingActivity reflecting = new ReflectingActivity();
                        reflecting.Begin();
                         break;
                    case "3":
                        ListingActivity listing = new ListingActivity();
                        listing.Start();
                        break;
                    case "4":
                        Console.WriteLine("Goodbye!");
                        return; // Exit the whole program
                    default:
                        Console.WriteLine("Invalid input. Please try again.");
                        break;
                }
            }
        }
    }
}
