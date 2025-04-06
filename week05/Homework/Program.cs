using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Homework Project.");

        System.Console.WriteLine();
        System.Console.WriteLine();
        Assignment assignment1 = new Assignment("Simeon Chirunga", "Probability");
        
        Console.WriteLine(assignment1.GetAssignmentDetails());
        System.Console.WriteLine();
        
        MathsAssignment assignment2 = new MathsAssignment("Marvellous Humphery", "Exponential Graphs", "13.1", "1-12");
        Console.WriteLine(assignment2.GetAssignmentDetails());
        System.Console.WriteLine();
        Console.WriteLine(assignment2.GetHomeworkList());
        System.Console.WriteLine();

        WritingAssignment assignment3 = new WritingAssignment("Matldah Sibanda", "Descriptive Composition", "Some animals are more equal than others");
        System.Console.WriteLine();
        Console.WriteLine(assignment3.GetAssignmentDetails());
        System.Console.WriteLine();
        Console.WriteLine(assignment3.GetWritingInformation());
    }
}