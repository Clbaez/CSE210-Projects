public class Resume
{
    public string _employeeName = "John Smith";
    public List<Job> _jobs = new List<Job>();

    public void DisplayResume()
    {
        Console.WriteLine($"Name: {_employeeName}");
        Console.WriteLine("Jobs:");
        foreach (Job job in _jobs)
        {
            job.DisplayJobDetails();
        }
    } 
}