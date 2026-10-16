using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Learning03 World!");

        // Fraction fraction1 = new Fraction();
        // Fraction fraction2 = new Fraction(6);
        // Fraction fraction3 = new Fraction(6, 7);

        // Console.WriteLine(fraction1.GetTop());
        // Console.WriteLine(fraction2.GetTop());
        // Console.WriteLine(fraction3.GetTop());

        // Console.WriteLine(fraction1.GetBottom());
        // Console.WriteLine(fraction2.GetBottom());
        // Console.WriteLine(fraction3.GetBottom());

        // fraction1.SetTop(3);
        // fraction2.SetTop(7);
        // fraction3.SetTop(5);

        // fraction1.SetBottom(2);
        // fraction2.SetBottom(8);
        // fraction3.SetBottom(1);

        // Console.WriteLine(fraction1.GetTop());
        // Console.WriteLine(fraction2.GetTop());
        // Console.WriteLine(fraction3.GetTop());

        // Console.WriteLine(fraction1.GetBottom());
        // Console.WriteLine(fraction2.GetBottom());
        // Console.WriteLine(fraction3.GetBottom());

        // Console.WriteLine(fraction1.GetFractionString());
        // Console.WriteLine(fraction2.GetFractionString());
        // Console.WriteLine(fraction3.GetFractionString());

        // Console.WriteLine(fraction1.GetDecimalValue());
        // Console.WriteLine(fraction2.GetDecimalValue());
        // Console.WriteLine(fraction3.GetDecimalValue());

        Fraction randomFraction = new Fraction();
        Random randomNumber = new Random();
        for (int i = 0; i <= 20; i++)
        {
            int top = randomNumber.Next(1, 10);
            int bottom = randomNumber.Next(1, 10);
            randomFraction.SetTop(top);
            randomFraction.SetBottom(bottom);
            string daString = randomFraction.GetFractionString();
            double daDecimal = randomFraction.GetDecimalValue();
            Console.WriteLine($"Fraction {i}: String: {daString} Decimal: {daDecimal:0.##}");
        }
    }
}