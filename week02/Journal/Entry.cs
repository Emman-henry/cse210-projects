using System;

namespace ConsoleApp1
{
    public class Entry
    {
        public string Prompt { get; set; }
        public string Response { get; set; }
        public DateTime Date { get; set; }

        public Entry(string prompt, string response)
        {
            Prompt = prompt;
            Response = response;
            Date = DateTime.Now;
        }

        public void DisplayEntry()
        {
            Console.WriteLine($"Date: {Date.ToShortDateString()}");
            Console.WriteLine($"Prompt: {Prompt}");
            Console.WriteLine($"Response: {Response}");
            Console.WriteLine();
        }
    }
}
