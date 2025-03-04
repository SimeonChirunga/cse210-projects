using System;

class Program
{
    
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise2 Project.");
        Console.Write("Please enter your percentage grade: ");
        string percentageGrade = Console.ReadLine();
        int mark = int.Parse(percentageGrade);
        int remainder= mark%10;
        char letter = ' ';
        char sign = ' ';
        if (mark >= 90)
            {
                letter = 'A';
            }
        else if (mark >= 80)
            {
                letter = 'B';
            }
        else if (mark >= 70)
            {
                letter = 'C';
            }
        else if (mark >= 60)
            {
                letter = 'D';
            }
        else if (mark < 60)
            {
                letter = 'F';
            }
        if ((remainder >= 7) && (mark < 90) && (mark> 60))
            {
                sign =  '+';
            }
        else if ((remainder <3) && (mark> 60))
            {
                sign =  '-';
            }

        Console.WriteLine($"Your grade is {letter}{sign}.");
       
        if (mark >= 70)
            {
                System.Console.WriteLine("Congratulations! You passed this exam.");
            }
        else
            {
                System.Console.WriteLine("You did not pass this exam. Do not despair, try again next time! You can do it");
            }


    }
}