using System;

namespace ConsoleApp1
{
    public class RecordGoals
    {
        public void Start()
        {
            Console.WriteLine("What goals did you achieve?");
            
            // For simplicity, assume that these are the goals in the session.
            // In a real case, you would pull this from GoalStorage or a similar mechanism.
            foreach (var goal in GoalStorage.SessionGoals)
            {
                Console.WriteLine($"Goal: {goal.Gname} | Description: {goal.Descrip} | Points: {goal.Point}");
            }

            // Simulate user completing goals
            Console.WriteLine("\nWhich goal did you complete? (Enter the goal's number)");
            int goalIndex = Convert.ToInt32(Console.ReadLine()) - 1;

            if (goalIndex < 0 || goalIndex >= GoalStorage.SessionGoals.Count)
            {
                Console.WriteLine("❌ Invalid goal selection.");
                return;
            }

            var goal = GoalStorage.SessionGoals[goalIndex];

            // Record completion
            if (goal is SimpleGoal simpleGoal)
            {
                Console.WriteLine($"✅ Simple Goal: {simpleGoal.Gname} is now completed!");
                // Track points earned
                simpleGoal.TrackPoints(50);  // Simple goals are 50 points.
            }
            else if (goal is EternalGoal eternalGoal)
            {
                Console.WriteLine($"🚫 Eternal Goal: {eternalGoal.Gname} cannot be completed.");
                // Eternal goals can't be "completed" but can still be recorded.
            }
            else if (goal is ChecklistGoal checklistGoal)
            {
                Console.WriteLine($"✅ Checklist Goal: {checklistGoal.Gname} - Stage 1 completed.");
                checklistGoal.TrackPoints(50);  // Track stage 1 completion (50 points per stage).
            }

            Console.WriteLine($"You have earned {goal.Point} points!");
        }
    }

    // Dummy goal classes
    public class SimpleGoal : Runner
    {
        public SimpleGoal(string gname, string descrip, string point) : base(gname, descrip, point) { }

        public void TrackPoints(int points)
        {
            // Assume points are tracked here.
            this.Point = points.ToString();
        }
    }

    public class EternalGoal : Runner
    {
        public EternalGoal(string gname, string descrip, string point) : base(gname, descrip, point) { }
    }

    public class ChecklistGoal : Runner
    {
        public int StagesCompleted { get; private set; }
        public ChecklistGoal(string gname, string descrip, string point) : base(gname, descrip, point) { }

        public void TrackPoints(int points)
        {
            StagesCompleted++;
            Console.WriteLine($"Stage {StagesCompleted} completed. ({StagesCompleted * 50}/150 points).");
            if (StagesCompleted == 3)
            {
                Console.WriteLine($"✅ Checklist Goal: {Gname} is completed!");
            }
        }
    }
}
