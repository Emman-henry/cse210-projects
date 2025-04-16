using System;

namespace ConsoleApp1
{
    public class RecordEvents
    {
        public int Start()
        {
            if (GoalStorage.SessionGoals.Count == 0)
            {
                Console.WriteLine("No goals available to record progress.");
                return 0;
            }

            Console.WriteLine("\nHere are your current goals:");
            for (int i = 0; i < GoalStorage.SessionGoals.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {GoalStorage.SessionGoals[i]}");
            }

            Console.Write("\nWhich goal did you accomplish? Enter the number: ");
            if (int.TryParse(Console.ReadLine(), out int choice) && choice > 0 && choice <= GoalStorage.SessionGoals.Count)
            {
                Runner selectedGoal = GoalStorage.SessionGoals[choice - 1];
                int earnedPoints = selectedGoal.RecordProgress();
                Console.WriteLine($"\n✅ Progress recorded! You earned {earnedPoints} points.");
                return earnedPoints;
            }
            else
            {
                Console.WriteLine("❌ Invalid choice. No goal recorded.");
                return 0;
            }
        }
    }
}
