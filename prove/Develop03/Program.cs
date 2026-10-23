using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("Welcome to the Scripture Memorizer!");
        Thread.Sleep(2500);

        Console.Clear();

        List<Scripture> scriptureList = new List<Scripture>();

        Reference john3_16R = new Reference("John", 3, 16);
        Reference proverbs3_5_6R = new Reference("Proverbs", 3, 5, 6);
        Reference helaman5_12R = new Reference("Helaman", 5, 12);

        Scripture john3_16S = new Scripture(john3_16R, "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.");
        Scripture proverbs3_5_6S = new Scripture(proverbs3_5_6R, "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths.");
        Scripture helaman5_12S = new Scripture(helaman5_12R, "And now, my sons, remember, remember that it is upon the rock of our Redeemer, who is Christ, the Son of God, that ye must build your foundation; that when the devil shall send forth his mighty winds, yea, his shafts in the whirlwind, yea, when all his hail and his mighty storm shall beat upon you, it shall have no power over you to drag you down to the gulf of misery and endless wo, because of the rock upon which ye are built, which is a sure foundation, a foundation whereon if men build they cannot fall.");

        scriptureList.Add(john3_16S);
        scriptureList.Add(proverbs3_5_6S);
        scriptureList.Add(helaman5_12S);

        Random random = new Random();
        int randomScripture = random.Next(0, 3);
        Scripture selectedScripture = scriptureList[randomScripture];

        selectedScripture.DisplayChallenge();
        Console.WriteLine();

        bool quit = false;

        while (quit == false)
        {
            bool complete = selectedScripture.IsComplete();

            Console.WriteLine("Press enter to continue or type 'quit' to quit.");
            string input = Console.ReadLine();
            if (input == "quit")
            {
                quit = true;
                Console.WriteLine("Goodbye!");
            }
            else
            {
                if (complete == true)
                {
                    quit = true;
                }
                else
                {
                    Console.Clear();
                    selectedScripture.MakeChallenge();
                    selectedScripture.DisplayChallenge();
                    Console.WriteLine();
                }
            }
        }
    }
}