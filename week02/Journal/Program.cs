using System;
using System.Collections.Generic;
using System.IO;

namespace ConsoleApp1
{
    class Program
    {
        static List<Entry> journalEntries = new List<Entry>();

        static void Main(string[] args)
        {
            PromptGenerator promptGenerator = new PromptGenerator();

            while (true)
            {
                Console.WriteLine("Welcome to the journal program");
                Console.WriteLine("Please select one of the following options:");
                Console.WriteLine("1. Write");
                Console.WriteLine("2. Display");
                Console.WriteLine("3. Load");
                Console.WriteLine("4. Save");
                Console.WriteLine("5. Quit");

                string userChoice = Console.ReadLine();

                switch (userChoice)
                {
                    case "1":
                        string prompt = promptGenerator.GetRandomPrompt();
                        Console.WriteLine("Prompt: " + prompt);
                        Console.WriteLine("Please enter your response:");
                        string response = Console.ReadLine();

                        Entry newEntry = new Entry(prompt, response);
                        journalEntries.Add(newEntry);
                        Console.WriteLine("Your response has been saved.");
                        break;

                    case "2":
                        if (journalEntries.Count == 0)
                        {
                            Console.WriteLine("No entries to display.");
                        }
                        else
                        {
                            foreach (Entry entry in journalEntries)
                            {
                                entry.DisplayEntry();
                            }
                        }
                        break;

                    case "3":
                        Console.WriteLine("Enter the filename to load the journal entries from:");
                        string filenameToLoad = Console.ReadLine();

                        if (File.Exists(filenameToLoad))
                        {
                            journalEntries.Clear();
                            using (StreamReader reader = new StreamReader(filenameToLoad))
                            {
                                string line;
                                while ((line = reader.ReadLine()) != null)
                                {
                                    string[] parts = line.Split('|');
                                    if (parts.Length == 3)
                                    {
                                        DateTime date = DateTime.Parse(parts[0]);
                                        string promptLoaded = parts[1];
                                        string responseLoaded = parts[2];

                                        Entry loadedEntry = new Entry(promptLoaded, responseLoaded) { Date = date };
                                        journalEntries.Add(loadedEntry);
                                    }
                                }
                            }
                            Console.WriteLine("Entries have been loaded from the file.");
                        }
                        else
                        {
                            Console.WriteLine("The file does not exist.");
                        }
                        break;
case "4":
    // Save entries to a file
    Console.WriteLine("Enter a filename to save the journal entries (e.g., my_journal.txt):");
    string filenameToSave = Console.ReadLine();

    try
    {
        // Ensure that the file is written in the current directory (or specify a path)
        using (StreamWriter writer = new StreamWriter(filenameToSave))
        {
            foreach (Entry entry in journalEntries)
            {
                // Save the entry in the format: Date | Prompt | Response
                writer.WriteLine($"{entry.Date.ToShortDateString()}|{entry.Prompt}|{entry.Response}");
            }
        }

        // Confirm the save
        Console.WriteLine($"Entries have been successfully saved to {filenameToSave}.");
    }
    catch (Exception ex)
    {
        // If there's an error, print it to the console
        Console.WriteLine("An error occurred while saving the file: " + ex.Message);
    }
    break;


                    case "5":
                        Console.WriteLine("Goodbye!");
                        return;

                    default:
                        Console.WriteLine("Invalid choice, please select a valid option.");
                        break;
                }
            }
        }
    }
}
