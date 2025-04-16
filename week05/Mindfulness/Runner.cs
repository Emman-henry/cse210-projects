using System;
using System.IO;

namespace ConsoleApp1
{
    public class Runner
    {
        protected string _gname;
        protected string _descrip;
        protected int _point;

        public string Gname
        {
            get { return _gname; }
            set { _gname = value; }
        }

        public string Descrip
        {
            get { return _descrip; }
            set { _descrip = value; }
        }

        public int Point
        {
            get { return _point; }
            set { _point = value; }
        }

        public Runner(string gname, string descrip, int point)
        {
            _gname = gname;
            _descrip = descrip;
            _point = point;
        }

        // Method to save to file
        public void SaveToFile(string fileName)
        {
            string content = $"Name: {Gname}\nDescription: {Descrip}\nPoints: {Point}\n";
            File.WriteAllText(fileName, content);
        }

        // Instance method to collect user input and store goal in memory
        public void Start()
        {
            Console.WriteLine("Creating a new goal...");

            Console.Write("Enter goal name: ");
            string name = Console.ReadLine();

            Console.Write("Enter goal description: ");
            string description = Console.ReadLine();

            Console.Write("Enter goal points: ");
            string points = Console.ReadLine();

            Runner goal = new Runner(name, description, points);

            // Store it for the current session
            GoalStorage.SessionGoals.Add(goal);

            Console.WriteLine("✅ Goal created and added to session!");
        }
    }
}
