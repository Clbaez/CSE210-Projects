class Word
{
    private string _word;
    private bool _isHidden;

    public Word(string word)
    {
        _word = word;
    }
    public void Hide()
    {
        _isHidden = true;
    }
    public void Display()
    {
        if(_isHidden == true)
        {
            for(int i = 0; i < _word.Length; i++)
            {
                Console.Write("_");
            }
        }
        else
        {
            Console.Write(_word);
        }
    }
    public bool Hidden()
    {
        return _isHidden;
    }
}