using System;
using System.Collections.Generic;

public class Scripture
{
    private ScriptureReference _reference;
    private List<ScriptureWord> _words;

    // Property to access the scripture reference
    public ScriptureReference Reference
    {
        get { return _reference; }
        set { _reference = value; }
    }

    // Property to access the list of words
    public List<ScriptureWord> Words
    {
        get { return _words; }
        set { _words = value; }
    }

    // Constructor that initializes the scripture
    public Scripture(ScriptureReference reference, string text)
    {
        _reference = reference;
        _words = new List<ScriptureWord>();
        foreach (var word in text.Split(' '))
        {
            _words.Add(new ScriptureWord(word));
        }
    }

    // Method to hide a certain number of words
    public void HideWords(int count)
    {
        Random rand = new Random();
        int hidden = 0;

        // Hide words randomly
        while (hidden < count && _words.Exists(w => !w.IsHidden))
        {
            int index = rand.Next(_words.Count);
            if (!_words[index].IsHidden)
            {
                _words[index].IsHidden = true;
                hidden++;
            }
        }
    }

    // Method to display the full scripture with hidden words
    public void DisplayScripture()
    {
        Console.Clear();
        Console.WriteLine(_reference.Reference);  // Display the reference (e.g., "Isaiah 60:22")
        foreach (var word in _words)
        {
            Console.Write(word.GetDisplayWord() + " ");
        }
        Console.WriteLine();
    }

    // Static method to get a random scripture
    public static Scripture GetNewScripture()
    {
        Random rand = new Random();
        int scriptureChoice = rand.Next(1, 4);  // Random number between 1 and 3

        switch (scriptureChoice)
        {
            case 1:
                return new Scripture(new ScriptureReference("Isaiah 60:22"), "When the time is right, I, the Lord, will make it happen");
            case 2:
                return new Scripture(new ScriptureReference("Proverbs 3:5-6"), "Trust in the Lord with all your heart and lean not on your own understanding; in all your ways acknowledge him, and he will make your paths straight.");
            case 3:
                return new Scripture(new ScriptureReference("John 3:16"), "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life.");
            default:
                return null;  // This case should not happen due to the range of the random number
        }
    }
}
