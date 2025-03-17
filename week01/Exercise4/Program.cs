using System;
using System.Collections.Generic;
using System.Linq; // Importing LINQ for Sum(), Average(), and Max() methods

class Program
{
    static void Main()
    {
        List<int> numbers = new List<int>();
        int number;

        Console.WriteLine("Please enter a list of numbers, Enter 0 when you finish:");

        // Loop until user enters 0
        while (true)
        {
            number = int.Parse(Console.ReadLine());

            if (number == 0)
            {
                break; // Exit loop when 0 is entered
            }

            numbers.Add(number); // Add number to list
        }

        // Output the entered numbers
        Console.WriteLine("You entered the following numbers:");
        foreach (var num in numbers)
        {
            Console.WriteLine(num); // Print each number
        }

        // Display the elements before calculating the average
        Console.WriteLine("\nDisplaying elements of the list:");
        numbers.ForEach(num => Console.WriteLine(num)); // Using LINQ to iterate and print each number

        // Calculate and output the total sum of the numbers
        double total = numbers.Sum(); // Sum using LINQ
        Console.WriteLine($"\nThe total of all numbers is: {total}");

        // Calculate and output the average of the numbers
        double average = numbers.Average(); // Average using LINQ
        Console.WriteLine($"The average is: {average}");

        // Find and output the largest number
        int largest = numbers.Max(); // Largest number using LINQ
        Console.WriteLine($"The largest number is: {largest}");
    }
}
