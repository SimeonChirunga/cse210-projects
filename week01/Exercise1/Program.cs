using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise1 Project.");
        System.Console.Write("What is your first name? ");
        string firstName = Console.ReadLine();
        System.Console.Write("What is your last name? ");
        string lastName = Console.ReadLine();
        System.Console.WriteLine($"Your name is {lastName}, {firstName} {lastName}.");
    }
}