using System;
using System.IO;

namespace ConsoleApp1
{
    public class LoadGoals
    {
        public void Start()
        {
            Console.Write("\nEnter the filename to load the goals: ");
            string filename = Console.ReadLine().Trim();

            if (!File.Exists(filename))
            {
                Console.WriteLine("❌ The file does not exist.");
                return;
            }

            try
            {
                GoalStorage.Clear();
                string[] lines = File.ReadAllLines(filename);
                foreach (var line in lines)
                {
                    string[] parts = line.Split(',');

                    if (parts.Length < 3) continue;

                    string type = parts[0].Trim(); // Identifying goal type
                    string name = parts[1].Trim();
                    string description = parts[2].Trim();
                    string points = parts[3].Trim();

                    if (type == "[ ]") // SimpleGoal
                    {
                        GoalStorage.AddGoal(new SimpleGoal(name, description, points));
                    }
                    else if (type == "[∞]") // EternalGoal
                    {
                        GoalStorage.AddGoal(new EternalGoal(name, description, points));
                    }
                    else if (type.StartsWith("[") && type.EndsWith("]")) // ChecklistGoal
                    {
                        int timesToComplete = int.Parse(parts[4].Trim());
                        GoalStorage.AddGoal(new ChecklistGoal(name, description, points, timesToComplete));
                    }
                }

                Console.WriteLine("✅ Goals loaded successfully!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"❌ Error loading goals: {ex.Message}");
            }
        }
    }
}
