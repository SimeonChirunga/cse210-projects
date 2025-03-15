using System;

public class PromptGenerator
{
    private string[] prompts = new string[]
    {
        "What am I grateful for today?",
        "What did I learn about myself today?",
        "How did I show love and kindness to others today?",
        "What is one thing I can improve on tomorrow?",
        "What Bible verse or spiritual principle did I apply to my life today?",
        "How did I take care of my physical and emotional health today?",
        "How did I use my time and talents to serve others today?",
        "What is one thing I'm thankful for in my relationships?",
        "How did I see God's beauty and wonder in the world today?",
        "What is one thing I can pray for or ask God for guidance on?",
        "How did I take risks or step outside my comfort zone today?",
        "What is one thing I learned from a failure or setback?",
        "How did I show forgiveness and mercy to myself or others today?",
    };


    public string GetRandomPrompt()
    {
        var random = new Random();
        return prompts[random.Next(prompts.Length)];
    }
}
