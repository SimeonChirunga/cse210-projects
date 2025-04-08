using System;
using System.Collections.Generic;
using System.Threading;

public class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;
    protected int _count;

   public Activity(string activityName, string activityDescription)
    {
        _name = activityName;
        _description = activityDescription;
        _count = 0;
        
    }


    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to the {_name} Activity.");
        Console.WriteLine(_description);
        Console.Write("How long would you like to spend on this activity (in seconds)? ");
        _duration = Convert.ToInt32(Console.ReadLine());

    }
    public int GetDuration()
    { 
        return _duration;
    }

    public  void DisplayEndingMessage()
    {
        Console.WriteLine($"Goodbye! You have done great as you have completed the {_name} Activity.");
        _count++;
    }

    public void ShowSpinner(int seconds)
    {
        for (int i = 0; i < seconds; i++)
        {
            Console.Write("/");
            Thread.Sleep(250);
            Console.Write("\b");
            Console.Write("-");
            Thread.Sleep(250);
            Console.Write("\b");
            Console.Write("\\");
            Thread.Sleep(250);
            Console.Write("\b");
            Console.Write("|");
            Thread.Sleep(250);
            Console.Write("\b");
        }
    }

    public void ShowCountDown(int _seconds)
    {
        for (int i = _seconds; i > 0; i--)
        {
            Console.WriteLine(i);
            Thread.Sleep(1000);
        }
    }

    public int GetCount()
    {
        return _count;
    }
    

}






