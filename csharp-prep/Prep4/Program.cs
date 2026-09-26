using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        bool finished = false;

        while (finished == false)
        {
            Console.Write("Enter number: ");

            string number_string = Console.ReadLine();
            int number = int.Parse(number_string);

            if (number != 0)
            {
                numbers.Add(number);
            }
            else
            {
                finished = true;
            }
        }

        int sum = 0;
        int largest = 0;

        foreach (int num in numbers)
        {
            sum += num;

            if (num > largest)
            {
                largest = num;
            }
        }

        float avg = (float)sum / numbers.Count;

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {avg}");
        Console.WriteLine($"The largest number is: {largest}");
    }
}