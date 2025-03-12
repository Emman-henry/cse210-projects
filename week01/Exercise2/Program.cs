using System;

class Program
{
    static void Main(string[] args)
    {
        int grade;
Console.WriteLine("What is your grade?");
grade = int.Parse(Console.ReadLine());

// Determine the letter grade first
string gradeLetter = "";
if (grade >= 90)
{
    gradeLetter = "A";
}
else if (grade >= 80)
{
    gradeLetter = "B";
}
else if (grade >= 70)
{
    gradeLetter = "C";
}
else if (grade >= 60)
{
    gradeLetter = "D";
}
else
{
    gradeLetter = "F";
}

// Now determine if the grade should have a "+" or "-" sign
string sign = ""; 

// For grades that are A, B, C, or D, we check the last digit
if (gradeLetter != "F")  // If it's not an F grade
{
    int lastDigit = grade % 10;  // Get the last digit by taking the remainder of division by 10
    
    // "+" for lastDigit >= 7, "-" for lastDigit < 3
    if (lastDigit >= 7)
    {
        sign = "+";
    }
    else if (lastDigit < 3)
    {
        sign = "-";
    }
}

// Handle the special cases for A+ and F+ / F-
if (gradeLetter == "A" && sign == "+")
{
    sign = ""; // No A+ grade, so remove the "+" sign
}
else if (gradeLetter == "F")
{
    sign = ""; // No F+ or F- grade, so remove the sign for F
}

// Display the final result
Console.WriteLine($"Your grade is {gradeLetter}{sign}");

    }
}