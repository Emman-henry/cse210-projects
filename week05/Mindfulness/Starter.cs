using System;
using System.Threading;

namespace ConsoleApp1
{
    // Base class
    public class Starter
    {
        // Protected fields, accessible by derived classes
        protected string _intro;
        protected string _description;
        protected string _timerPrompt;
        protected string _checkingText;
        protected string _closingText; // New field for closing message

        // Public properties with getters and setters
        public string Intro
        {
            get { return _intro; }
            set { _intro = value; }
        }

        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }

        public string TimerPrompt
        {
            get { return _timerPrompt; }
            set { _timerPrompt = value; }
        }

        public string ClosingText
        {
            get { return _closingText; }
            set { _closingText = value; }
        }

        // Constructor to initialize the private fields
        public Starter(string intro, string description, string timerPrompt, string checkingText)
        {
            this._intro = intro;
            this._description = description;
            this._timerPrompt = timerPrompt;
            this._checkingText = checkingText;  
        }

        // New constructor to include the closing message
        public Starter(string intro, string description, string timerPrompt, string checkingText, string closingText)
        {
            this._intro = intro;
            this._description = description;
            this._timerPrompt = timerPrompt;
            this._checkingText = checkingText;
            this._closingText = closingText; // Initialize the new field
        }

        // Spinner animation method
        public void Spinners()
        {
            List<string> spinner = new List<string>() { "/", "-", "|", "\\", "-", "/" };

            foreach (string spin in spinner)
            {
                Console.Clear(); // Clear the console line to avoid overlap
                Console.Write(spin); // Display the spinner character
                Thread.Sleep(1000); // Small pause to simulate "spin"
                Console.Write("\b \b"); // Erase the character from the console
            }
        }
    }
}
