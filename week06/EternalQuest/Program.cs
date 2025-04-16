using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalPoints = 0;

            while (true)
            {
                Console.Clear();
                Console.WriteLine($"Total Points: {totalPoints}");
                Console.WriteLine("\nMenu options:");
                Console.WriteLine("1. Create new goals");
                Console.WriteLine("2. List Goals");
                Console.WriteLine("3. Save Goals");
                Console.WriteLine("4. Load Goals");
                Console.WriteLine("5. Record Events");
                Console.WriteLine("6. Quit");
                Console.Write("Select an option: ");

                string input = Console.ReadLine().Trim();

                switch (input)
                {
                    case "1":
                        new CreateGoals().Start();
                        break;
                    case "2":
                        new ListGoals().Start();
                        break;
                    case "3":
                        new SaveGoals().Begin();
                        break;
                    case "4":
                        new LoadGoals().Start();
                        break;
                    case "5":
                        totalPoints += new RecordEvents().Start();
                        break;
                    case "6":
                        Console.WriteLine("Goodbye!");
                        return;
                    default:
                        Console.WriteLine("Invalid option, try again.");
                        break;
                }

                Console.WriteLine("\nPress Enter to continue...");
                Console.ReadLine();
            }
        }
    }
}
