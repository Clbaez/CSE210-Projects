class Assignment
{
    // attributes
    private string _studentName;
    private string _topic;

    // behaviors
    public Assignment(string name, string topic)
    {
        _topic = topic;
        _studentName = name;
    }
    public string GetSummary()
    {
        return _studentName + " - " + _topic;
    }
}