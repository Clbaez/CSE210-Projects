using System;

class Program
{
    static void Main(string[] args)
    {
        string play = "yes";
        while (play == "yes")
        {
        Random random_generator = new Random();
        int magic_int = random_generator.Next(1,101);

        bool correct = false;

        int guess_count = 0;
        while (correct == false)
            {
                Console.Write("What is your guess? ");
                string guess_string = Console.ReadLine();
                int guess_int = int.Parse(guess_string);

                if (guess_int < magic_int)
                {
                    guess_count ++;
                    Console.WriteLine("Higher");
                }

                else if (guess_int > magic_int)
                {
                    guess_count ++;
                    Console.WriteLine("Lower");
                }

                else
                {
                    guess_count ++;
                    Console.WriteLine("You guessed it!");
                    Console.WriteLine($"You made {guess_count} guesses.");
                    correct = true;
                }
            }
            if (correct == true)
            {
                Console.Write("Would you like to play again? ");
                play = Console.ReadLine();
            }
        }
    }
}