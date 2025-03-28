namespace ConsoleApp1
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            // Create instances of the Fraction class using the different constructors

            // Using the constructor with no parameters (defaults to 1/1)
            Fraction fraction1 = new Fraction();
            Console.WriteLine(fraction1.GetFractionString()); // Output: 1/1
            Console.WriteLine(fraction1.GetDecimalValue());  // Output: 1

            // Using the constructor with one parameter (sets numerator, denominator is 1)
            Fraction fraction2 = new Fraction(5);
            Console.WriteLine(fraction2.GetFractionString()); // Output: 5/1
            Console.WriteLine(fraction2.GetDecimalValue());  // Output: 5

            // Using the constructor with two parameters (sets numerator and denominator)
            Fraction fraction3 = new Fraction(3, 4);
            Console.WriteLine(fraction3.GetFractionString()); // Output: 3/4
            Console.WriteLine(fraction3.GetDecimalValue());  // Output: 0.75

            // Using the constructor with two parameters (sets numerator and denominator)
            Fraction fraction4 = new Fraction(1, 3);
            Console.WriteLine(fraction4.GetFractionString()); // Output: 1/3
            Console.WriteLine(fraction4.GetDecimalValue());  // Output: 0.3333333333333333

            // Modify the values using setters
            fraction3.Numerator = 6;
            fraction3.Denominator = 7;
            Console.WriteLine(fraction3.GetFractionString()); // Output: 6/7
            Console.WriteLine(fraction3.GetDecimalValue());  // Output: 0.8571428571428571
        }
    }
}
