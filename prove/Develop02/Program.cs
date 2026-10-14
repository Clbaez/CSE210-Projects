using System.Security.Cryptography.X509Certificates;
using System.Xml.Serialization;
using System.IO;

namespace Journal;

class Program
{
    static void Main(string[] args)
    {
        Journal myJournal = new Journal();

        List<string> prompts = new List<string>();
        prompts.Add("Who was the most interesting person I interacted with today?");
        prompts.Add("What was the best part of my day?");
        prompts.Add("How did I see the hand of the Lord in my life today?");
        prompts.Add("What was the strongest emotion I felt today?");
        prompts.Add("If I had one thing I could do over today, what would it be?");
        // prompts.Add("");

        myJournal._prompts = prompts;
        
        bool quit = false;
        while (quit == false)
        {
            Console.Write(@"

What would you like to do?

1. Write New Entry
2. Display the Journal
3. Save the Journal
4. Load the Journal
5. Quit

Please enter your choice: ");

            string response = Console.ReadLine();
            int choice;
            while (! int.TryParse(response, out choice))
            {
                Console.WriteLine("\nInvalid choice.");
                Console.Write("Please enter your choice: ");
                response = Console.ReadLine();
            }

            if (choice == 1)
            {
                Console.WriteLine("Preparing new entry...\n");
                myJournal.AddEntry();
            }
            else if (choice == 2)
            {
                Console.WriteLine("Displaying the Journal...\n");
                myJournal.DisplayEntry();
            }
            else if (choice == 3)
            {
                Console.WriteLine("Saving the Journal...\n");

                string filename = "myJournal.txt";
                using (StreamWriter outputFile = new StreamWriter(filename))
                {
                    foreach (Entry entry in myJournal._entries)
                    {
                        outputFile.WriteLine(entry._date);
                        outputFile.WriteLine(entry._prompt);
                        outputFile.WriteLine(entry._response);
                    }
                }
            }
            else if (choice == 4)
            {
                Console.WriteLine("Loading the Journal...\n");

                string filename = "myJournal.txt";
                string[] lines = System.IO.File.ReadAllLines(filename);
                int fileLength = lines.Length;
                for (int i = 0; i < fileLength; i += 3)
                {
                    Entry entry = new Entry();
                    entry._date = lines[i];
                    entry._prompt = lines[i + 1];
                    entry._response = lines[i + 2];
                    myJournal._entries.Add(entry);
                }
            }
            else if (choice == 5)
            {
                Console.WriteLine("Goodbye!");
                quit = true;
            }
        }
    }

      
}