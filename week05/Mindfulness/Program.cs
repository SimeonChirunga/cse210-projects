using System;
// added another activity to the mindfulness project (SelfCompassionActivity)
// keepping track of the number of times each activity has been performed
class Program
{
    static Breathing breathingActivity = new Breathing("Breathing", "This activity will help you relax by guiding you through breathing exercises. Clear your mind and focus on your breathing!!");
    static Listing listingActivity = new Listing("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
    static ReflectingActivity reflectingActivity = new ReflectingActivity("Reflecting", "This activity will help you reflect on your experiences when you have shown strength and resiliance. This will help you recognize the power you have and how you can use it in other aspects of your life..");
    static SelfCompassionActivity selfCompassionActivity = new SelfCompassionActivity("Self-Compassion", "This activity will help you think about self-compassion and kindness towards yourself, and to practice self-care and self-forgiveness.");

    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Mindfulness Project.");
        while (true)
        {
            DisplayMenu();
            if (int.TryParse(Console.ReadLine(), out int option))
            {
                switch (option)
                {
                    case 1:
                        breathingActivity.Run();
                        break;
                    case 2:
                        listingActivity.Run();
                        break;
                    case 3:
                        reflectingActivity.Run();
                        break;
                    case 4:
                        selfCompassionActivity.Run();
                        break;
                    case 5:
                        Console.WriteLine("Goodbye!");
                        return;
                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a number.");
            }
        }
    }
    static void DisplayMenu()
    {
        Console.WriteLine("Welcome to the Mindfulness Program!");
        Console.WriteLine("Please select an option:");
        Console.WriteLine($"1. Breathing Activity (Performed {breathingActivity.GetCount()} times)");
        Console.WriteLine($"2. Listing Activity (Performed {listingActivity.GetCount()} times)");
        Console.WriteLine($"3. Reflecting Activity (Performed {reflectingActivity.GetCount()} times)");
        Console.WriteLine($"4. Self-Compassion Activity (Performed {selfCompassionActivity.GetCount()} times)");
        Console.WriteLine("5. Quit");
    }
}
