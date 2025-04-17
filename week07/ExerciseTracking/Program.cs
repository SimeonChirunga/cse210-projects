using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ExerciseTracking Project.");
        List<Activity> activities = new List<Activity>()
        {
            new Running(DateTime.Parse("2025-01-03"), 30, 6.8),
            new Cycling(DateTime.Parse("2025-01-03"), 30, 10.7),
            new Swimming(DateTime.Parse("2025-01-07"), 30, 20)
        };

        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}

    