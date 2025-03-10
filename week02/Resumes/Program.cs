using System;
using System.Threading.Tasks.Dataflow;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Resumes Project.");
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Simdah";
        job1._startYear = 2010;
        job1._endYear = 2013;
        Job job2 = new Job();
        job2._jobTitle = "Programmer";
        job2._company = "Google";
        job2._startYear = 2013;
        job2._endYear = 2019;
        // job1.Display();
        Resume resume = new Resume();
        resume._jobs.Add(job1);
        resume._jobs.Add(job2);
        string jobname = resume._jobs[1]._jobTitle;
        resume.display();
        System.Console.WriteLine(jobname);
        // System.Console.WriteLine(job2._company);


    }
}