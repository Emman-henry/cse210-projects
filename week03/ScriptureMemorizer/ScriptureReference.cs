// Class representing a Scripture Reference (e.g., John 3:16 or Proverbs 3:5-6)
public class ScriptureReference
{
    // Private member variable
    private string _reference;

    // Public property to access and modify the reference
    public string Reference
    {
        get { return _reference; } // Getter to access the private field
        set { _reference = value; } // Setter to modify the private field
    }

    // Constructor for single verse
    public ScriptureReference(string reference)
    {
        _reference = reference;
    }

    // Constructor for verse range (e.g., "Proverbs 3:5-6")
    public ScriptureReference(string referenceStart, string referenceEnd)
    {
        _reference = $"{referenceStart}-{referenceEnd}";
    }
}
