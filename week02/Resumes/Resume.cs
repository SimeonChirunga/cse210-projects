public class Resume
{
    public string _personName;
    public List<Job> _jobs = new List<Job>();

    public void display()
    {
        _personName = "Simeon";
        Console.WriteLine(_personName);
        System.Console.WriteLine("Jobs");
        foreach (Job job in _jobs)
        {


            System.Console.WriteLine(job._jobTitle);
            System.Console.WriteLine(job._company);
            System.Console.WriteLine(job._startYear);
            System.Console.WriteLine(job._endYear);
            System.Console.WriteLine();
        }

        
    }
}

