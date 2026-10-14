namespace Journal;

class Journal
{
    // Attributes
    public List<Entry> _entries = new List<Entry>();

    public List<string> _prompts;
    // Behaviors
    public void AddEntry()
    {
        DateTime currentTime = DateTime.Now;
        string dateString = currentTime.ToShortDateString();
        Console.WriteLine($"{dateString}\n");

        Random random = new Random();
        int randomIndex = random.Next(0, 4);
        string prompt = _prompts[randomIndex];
        Console.WriteLine($"{prompt}\n");

        string response = Console.ReadLine();

        Entry entry = new Entry();
        entry._date = dateString;
        entry._prompt = prompt;
        entry._response = response;

        _entries.Add(entry);
    }
    public void DisplayEntry()
    {
        foreach (Entry entry in _entries)
        {
            Console.WriteLine(entry._date);
            Console.WriteLine(entry._prompt);
            Console.WriteLine(entry._response);
        }
    }
}