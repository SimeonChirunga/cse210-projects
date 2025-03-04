using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise5 Project.");
        DisplayWelcome();
        string name = PromptUserName();
        int number = PromptUserNumber();
        int square = SquareNumber(number);
        DisplayResult(name, square);
    }
    static void DisplayWelcome()
    {
        System.Console.WriteLine("Welcome to the Program!");
    }
    static string PromptUserName()
    {
        System.Console.WriteLine("Please enter your name");
        string userName = Console.ReadLine();
        return userName;
    }
    static int PromptUserNumber()
    {
        System.Console.WriteLine("Please enter your favorite number");
        int userNumber = int.Parse(Console.ReadLine());
        return userNumber;
    }
    static int SquareNumber(int number)
    {
        return number * number;
    }
    static void DisplayResult(string name, int number)
    {
        System.Console.WriteLine($"{name}, the square of your number is {number}");
    }

}