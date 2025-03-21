// Class representing a Word in the scripture
public class ScriptureWord
{
    // Private member variables
    private string _word;
    private bool _isHidden;

    // Public property to access and modify the word
    public string Word
    {
        get { return _word; } // Getter to access the private field
        set { _word = value; } // Setter to modify the private field
    }

    // Public property to access and modify whether the word is hidden
    public bool IsHidden
    {
        get { return _isHidden; } // Getter for IsHidden
        set { _isHidden = value; } // Setter for IsHidden
    }

    // Constructor
    public ScriptureWord(string word)
    {
        _word = word;
        _isHidden = false;
    }

    // Method to get the word or return underscores if it's hidden
    public string GetDisplayWord()
    {
        return _isHidden ? new string('_', _word.Length) : _word;
    }
}
