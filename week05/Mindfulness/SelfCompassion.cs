public class SelfCompassionActivity : Activity
{
    private string[] prompts = new string[]
    {
        "What are some things you're grateful for about yourself?",
        "What are some ways you take care of yourself?",
        "What are some things you're kind to yourself about?",
        "What are some ways you can practice self-forgiveness?"
    };

    private string[] affirmations = new string[]
    {
        "I am enough exactly as I am.",
        "I am worthy of love and respect.",
        "I am capable of handling whatever comes my way.",
        "I am kind and compassionate towards myself."
    };

    public SelfCompassionActivity(string name, string description) : base(name, description)
    {
    }

    public void Run()
    {
        base.DisplayStartingMessage();
        base.GetDuration();

        Console.WriteLine("Let's take a few moments to think about self-compassion and kindness towards yourself.");

        foreach (string prompt in prompts)
        {
            Console.WriteLine(prompt);
            Console.WriteLine("Take a few deep breaths and think about your answer...");
            System.Threading.Thread.Sleep((_duration * 1000)/4);
        }

        Console.WriteLine("Now, let's take a few moments to repeat some affirmations to ourselves.");

        foreach (string affirmation in affirmations)
        {
            Console.WriteLine(affirmation);
            Console.WriteLine("Repeat this to yourself and really feel the meaning of the words...");
            System.Threading.Thread.Sleep((_duration * 1000)/4); 
        }

        Console.WriteLine("Remember, self-compassion is an important part of taking care of yourself. Take a few moments each day to practice kindness and forgiveness towards yourself.");
        base.DisplayEndingMessage();
    }
}
