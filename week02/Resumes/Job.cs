public class Job
{
    // Private member variables (fields)
    private string _jobTitle;
    private string _company;
    private decimal _salary;
    private string _location;

    // Constructor to initialize the job class
    public Job(string jobTitle, string company, decimal salary, string location)
    {
        _jobTitle = jobTitle;   // Fixed the capitalization issue
        _company = company;
        _salary = salary;
        _location = location;
    }

    // Properties to access private fields
    public string JobTitle
    {
        get { return _jobTitle; }
        set { _jobTitle = value; }
    }

    public string Company
    {
        get { return _company; }
        set { _company = value; }
    }

    public decimal Salary
    {
        get { return _salary; }
        set { _salary = value; }
    }

    public string Location
    {
        get { return _location; }
        set { _location = value; }
    }

    // Method to display job information
    public void DisplayJobInfo()
    {
        Console.WriteLine($"Job Title: {_jobTitle}");
        Console.WriteLine($"Company: {_company}");
        Console.WriteLine($"Salary: {_salary:C}");  // Display salary in currency format
        Console.WriteLine($"Location: {_location}");
    }
}

