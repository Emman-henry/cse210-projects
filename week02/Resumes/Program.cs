using System;

class Program
{
    static void Main(string[] args)
    {
        
            // Create the first job instance and set its properties using dot notation
            Job job1 = new Job("Software Engineer", "Tech Innovations", 90000, "San Francisco");
            
            // Using dot notation to access the member variable and displaying the company
            Console.WriteLine("Job 1 Company: " + job1.Company);

            // Create the second job instance and set its properties using dot notation
            Job job2 = new Job("Data Scientist", "Data Insights", 105000, "New York");

            // Using dot notation to access the member variable and displaying the company
            Console.WriteLine("Job 2 Company: " + job2.Company);
        
    }
}