using System;
using System.IO;

namespace ConsoleApp1
{
    public class SaveGoals
    {
        public void Begin()
        {
            Console.Write("\nEnter the filename to save the goals: ");
            string filename = Console.ReadLine().Trim();

            try
            {
                using (StreamWriter writer = new StreamWriter(filename))
                {
                    foreach (var goal in GoalStorage.SessionGoals)
                    {
                        writer.WriteLine(goal.ToString());
                    }
                }
                Console.WriteLine("✅ Goals saved successfully!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"❌ Error saving goals: {ex.Message}");
            }
        }
    }
}
