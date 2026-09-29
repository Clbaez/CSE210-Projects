using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();

        job1._company = "Apple";
        job1._jobTitle = "Software Engineer";
        job1._startYear = 1997;
        job1._endYear = 2005;
        
        job1.DisplayJobDetails();

        Job job2 = new Job();

        job2._company = "Microsoft";
        job2._jobTitle = "Software Engineer";
        job2._startYear = 2007;
        job2._endYear = 2011;

        job2.DisplayJobDetails();

        Resume myresume = new Resume();

        myresume._jobs = [job1, job2];

        myresume.DisplayResume();
    }
}