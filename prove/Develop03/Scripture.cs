class Scripture
{
    private List<Word> _words = new List<Word>();
    private Reference _reference;

    public Scripture(Reference reference, string verse)
    {
        _reference = reference;
        string[]words = verse.Split(" ");
        foreach (string word in words)
        {
            Word text = new Word(word);
            _words.Add(text);
        }
    }
    public void MakeChallenge()
    {
        List<Word> visibleWords = new List<Word>();
        foreach (Word word in _words)
        {
            bool status = word.Hidden();
            if(status == false)
            {
                visibleWords.Add(word);
            }
        }
        Random random = new Random();

        if (visibleWords.Count == 0)
        {
            return;
        }

        int random1 = random.Next(0, visibleWords.Count);
        visibleWords[random1].Hide();
        visibleWords.RemoveAt(random1);

        if (visibleWords.Count == 0)
        {
            return;
        }

        int random2 = random.Next(0, visibleWords.Count);
        visibleWords[random2].Hide();
        visibleWords.RemoveAt(random2);

        if (visibleWords.Count == 0)
        {
            return;
        }

        int random3 = random.Next(0, visibleWords.Count);
        visibleWords[random3].Hide();
        visibleWords.RemoveAt(random3);
    }
    public void DisplayChallenge()
    {
        Console.WriteLine(_reference.GetDisplayText());
        foreach (Word word in _words)
        {
            word.Display();
            Console.Write(" ");
        }
        Console.WriteLine(" ");
    }
    public bool IsComplete()
    {
        bool complete = false;

        List<Word> visibleWords = new List<Word>();
        foreach (Word word in _words)
        {
            bool status = word.Hidden();
            if(status == false)
            {
                visibleWords.Add(word);
            }
        }
        if (visibleWords.Count == 0)
        {
            complete = true;
        }
        return complete;
    }
}