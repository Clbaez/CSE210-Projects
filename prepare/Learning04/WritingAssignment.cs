class WritingAssignment : Assignment
{
    // attributes
    private string _title;

    // behaviors
    public WritingAssignment(string name, string topic, string title) : base(name, topic)
    {
        _title = title;
    }
    public string GetWritingInformation()
    {
        return _title;
    }
}