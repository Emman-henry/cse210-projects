namespace ConsoleApp1
{
    using System;

    public class Fraction
    {
        // Private fields for the numerator (top) and denominator (bottom)
        private int numerator;
        private int denominator;

        // Constructor with no parameters (defaults to 1/1)
        public Fraction()
        {
            numerator = 1;
            denominator = 1;
        }

        // Constructor with one parameter for the numerator (defaults denominator to 1)
        public Fraction(int numerator)
        {
            this.numerator = numerator;
            this.denominator = 1;
        }

        // Constructor with two parameters (numerator and denominator)
        public Fraction(int numerator, int denominator)
        {
            // Validate the denominator to avoid division by zero
            if (denominator == 0)
            {
                throw new ArgumentException("Denominator cannot be zero.");
            }

            this.numerator = numerator;
            this.denominator = denominator;
        }

        // Getter and Setter for Numerator
        public int Numerator
        {
            get { return numerator; }
            set { numerator = value; }
        }

        // Getter and Setter for Denominator
        public int Denominator
        {
            get { return denominator; }
            set
            {
                if (value == 0)
                {
                    throw new ArgumentException("Denominator cannot be zero.");
                }
                denominator = value;
            }
        }

        // Method to return the fraction as a string in the format "numerator/denominator"
        public string GetFractionString()
        {
            return $"{numerator}/{denominator}";
        }

        // Method to return the decimal value of the fraction
        public double GetDecimalValue()
        {
            return (double)numerator / denominator;
        }
    }
}
