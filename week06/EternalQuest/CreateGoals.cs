using System;

namespace ConsoleApp1
{
    public class CreateGoals
    {
        public void Start()
        {
            Console.WriteLine("Select the type of goal to create:");
            Console.WriteLine("1. Simple Goal");
            Console.WriteLine("2. Eternal Goal");
            Console.WriteLine("3. Checklist Goal");

            string choice = Console.ReadLine();

            Console.Write("Enter the name of the goal: ");
            string name = Console.ReadLine();

            Console.Write("Enter the description: ");
            string description = Console.ReadLine();

            Console.Write("Enter the points for this goal: ");
            string points = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    GoalStorage.AddGoal(new SimpleGoal(name, description, points));
                    break;
                case "2":
                    GoalStorage.AddGoal(new EternalGoal(name, description, points));
                    break;
                case "3":
                    Console.Write("Enter the number of times to complete: ");
                    int times = int.Parse(Console.ReadLine());
                    GoalStorage.AddGoal(new ChecklistGoal(name, description, points, times));
                    break;
                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
        }
    }
}
