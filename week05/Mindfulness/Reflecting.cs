public class ReflectingActivity : Activity
{
    private string[] _prompts;
    private string[] _questions;

    public ReflectingActivity(string name, string description) : base(name, description) 
    { 
        _prompts = new string[] { "Think of a time when you stood up for someone else.", "Think of a time when you did something really difficult.", "Think of a time when you helped someone in need.", "Think of a time when you did something truly selfless." };
        _questions = new string[] { "Why was this experience meaningful to you?", "Have you ever done anything like this before?", "How did you get started?", "How did you feel when it was complete?", "What made this time different than other times when you were not as successful?", "What is your favorite thing about this experience?", "What could you learn from this experience that applies to other situations?", "What did you learn about yourself through this experience?", "How can you keep this experience in mind in the future?" };

    }

    public void Run()
    {
        DisplayStartingMessage();
        string _prompt = GetRandomPrompt();
        DisplayPrompt(_prompt);
        ShowCountDown(5);
        DisplayQuestions(_duration);
        DisplayEndingMessage();
    }

    private string GetRandomPrompt()
    {
        Random random = new Random();
        return _prompts[random.Next(_prompts.Length)];
    }

    private string GetRandomQuestion()
    {
        Random random = new Random();
        return _questions[random.Next(_questions.Length)];
    }

    private void DisplayPrompt(string prompt)
    {
        Console.WriteLine(prompt);
    }

    private void DisplayQuestions(int duration)
    {
        int startTime = Environment.TickCount;
        while (Environment.TickCount - startTime < duration * 1000)
        {
            string question = GetRandomQuestion();
            Console.WriteLine(question);
            ShowSpinner(4);
        }
    }
}



