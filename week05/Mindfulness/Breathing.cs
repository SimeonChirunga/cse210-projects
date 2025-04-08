public class Breathing : Activity
{
    public Breathing(string _name, string _description) : base(_name, _description)
 { }

    public void Run()
    {
        DisplayStartingMessage();
        ShowCountDown(5);
        int startTime = Environment.TickCount;
        while (Environment.TickCount - startTime < _duration * 1000)
        {
            Console.WriteLine("Breathe in...");
            ShowSpinner(4);
            Console.WriteLine("Hold...");
            ShowSpinner(4);
            Console.WriteLine("Breathe out...");
            ShowSpinner(4);
        }
        // {
        //     Console.WriteLine("Breathe in...");
        //     ShowSpinner(4);
        //     Console.WriteLine("Breathe out...");
        //     ShowSpinner(4);
        // }
        DisplayEndingMessage();
    }
}