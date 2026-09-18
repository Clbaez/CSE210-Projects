using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string grade = Console.ReadLine();
        int gradeNumber = int.Parse(grade);

        string letter;
        bool passed;

        if (gradeNumber >= 90)
        {
            letter = "A";
            passed = true;
        }
        else if (gradeNumber >= 80)
        {
            letter = "B";
            passed = true;
        }
        else if (gradeNumber >= 70)
        {
            letter = "C";
            passed = true;
        }
        else if (gradeNumber >= 60)
        {
            letter = "D";
            passed = false;
        }
        else
        {
            letter = "F";
            passed = false;
        }
        Console.WriteLine($"Your grade is {letter}");
        if (passed == true)
        {
            Console.WriteLine("You have passed the class!");
        }
        else
        {
            Console.WriteLine("You have failed the class.");
        }

    }
}