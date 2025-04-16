using System;

namespace ConsoleApp1
{
    public class ListGoals
    {
        public void Start()
        {
            if (GoalStorage.SessionGoals.Count == 0)
            {
                Console.WriteLine("No goals have been added yet.");
                return;
            }

            Console.WriteLine("\nYour current goals:");
            int count = 1;
            foreach (var goal in GoalStorage.SessionGoals)
            {
                Console.WriteLine($"{count++}. {goal}");
            }
        }
    }
}
