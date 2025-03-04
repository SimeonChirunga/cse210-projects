using System;
using System.Security.AccessControl;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise4 Project.");
        
        List<int> numbers = new List<int>();
        System.Console.WriteLine("Enter a number to add to the list. Enter 0 to stop");
        System.Console.Write("Enter a number ");
        string userinput = Console.ReadLine();
        int number = int.Parse(userinput);
        int count =0;
        int sum = 0;
        
        while (number != 0)
            {
                
                numbers.Add(number);
                System.Console.Write("Enter a number number ");
                count++;
                sum = sum + number;
                userinput = Console.ReadLine();
                number = int.Parse(userinput);
            } 
        decimal average = (decimal) (sum)/(decimal)(count);
        int smallestPositive = 99999999;
        numbers.Sort();
        foreach (int num in numbers)
        {
            if (num > 0)
            {
                if (num < smallestPositive) 
                {
                    smallestPositive = num;
                }
            }
        }

        System.Console.WriteLine($"The sum is: {sum}");
        System.Console.WriteLine($"The average is: {average}");
        System.Console.WriteLine($"The maximum is: {numbers.Max()}");
        System.Console.WriteLine($"The smallest positive is: {smallestPositive}");
        System.Console.WriteLine("The sorted list is:");
        foreach (int num in numbers)
        {
            System.Console.WriteLine(num);
            
        }

       


    }
}