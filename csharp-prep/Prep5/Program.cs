using System;
using System.Data;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();

        string name = PromptUserName();

        int favNumber = PromptUserNumber();

        PromptUserBirthYear(out int birthYear);

        int squareNumber = SquareNumber(favNumber);

        DisplayResult(name, squareNumber, birthYear);
    }

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }

    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();

        return name;
    }

    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        string number = Console.ReadLine();
        int favNumber = int.Parse(number);

        return favNumber;   
    }

    static void PromptUserBirthYear(out int birthYear)
    {
        Console.Write("Please enter the year you were born: ");
        string birth = Console.ReadLine();
        birthYear = int.Parse(birth);
    }

    static int SquareNumber(int favNumber)
    {
        int squareNumber = favNumber * favNumber;

        return squareNumber;
    }

    static void DisplayResult(string name, int squareNumber, int birthYear)
    {
        int year = 2026;
        int age = year - birthYear;
        Console.WriteLine($"{name}, the square of your number is {squareNumber}");
        Console.WriteLine($"{name}, you will turn {age} this year");
    }
}