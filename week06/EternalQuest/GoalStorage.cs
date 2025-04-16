using System.Collections.Generic;

namespace ConsoleApp1
{
    public static class GoalStorage
    {
        // Holds all goals created during the current session
        public static List<Runner> SessionGoals { get; set; } = new List<Runner>();

        // Adds a goal to the session list
        public static void AddGoal(Runner goal)
        {
            SessionGoals.Add(goal);
        }

        // Clears all session goals
        public static void Clear()
        {
            SessionGoals.Clear();
        }
    }
}
