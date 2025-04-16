using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    public class ListGoals
    {
        public void Start()
        {
            Console.WriteLine("\n📋 Listing all goals created in this session:\n");

            if (GoalStorage.SessionGoals.Count == 0)
            {
                Console.WriteLine("⚠️ No goals have been created yet.");
                return;
            }

            int count = 1;
            foreach (var goal in GoalStorage.SessionGoals)
            {
                Console.WriteLine($"{count}. 🏁 Goal Name: {goal.Gname}");
                Console.WriteLine($"   📝 Description: {goal.Descrip}");
                Console.WriteLine($"   🎯 Points: {goal.Point}\n");
                count++;
            }
        }
    }
}
