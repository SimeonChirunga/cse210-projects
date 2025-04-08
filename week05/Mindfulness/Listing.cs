public class Listing : Activity
{
    private string[] _prompts = {  };
    protected int _count;

    public Listing(string activityName, string activityDescription) 
    : base(activityName, activityDescription) 
{
    _count = 0;
    _prompts = new string[] { "Who are people that you appreciate?", "What are personal strengths of yours?", "Who are people that you have helped this week?", "When have you felt the Holy Ghost this month?", "Who are some of your personal heroes?" };
}




    public void Run()
    {
        DisplayStartingMessage();
        string prompt = GetRandomPrompt();
        Console.WriteLine(prompt);
        ShowCountDown(5);
        List<string> list = GetListFromUser();
        Console.WriteLine($"You listed {_count} items.");
        DisplayEndingMessage();
    }

    private string GetRandomPrompt()
    {
        Random random = new Random();
        return _prompts[random.Next(_prompts.Length)];
    }

    private List<string> GetListFromUser()
    {
        List<string> list = new List<string>();
        int startTime = Environment.TickCount;
        while (Environment.TickCount - startTime < _duration* 1000)
        {
            Console.WriteLine("You have 5 seconds to enter an item. Press Enter to stop.");
            string input = Console.ReadLine();
            if (string.IsNullOrEmpty(input))
            {
                break;
            }
            list.Add(input);
        }
        {
            Console.Write("Enter an item: ");
            string item = Console.ReadLine();
            list.Add(item);
            _count++;
        }
        return list;
    }
}