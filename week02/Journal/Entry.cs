using System;

public class Entry
{
    public string Date { get; set; }
    public string Prompt { get; set; }
    public string Response { get; set; }
    public List<string> Tags { get; set; }

    public Entry(string date, string prompt, string response)
    {
        Date = date;
        Prompt = prompt;
        Response = response;
        Tags = new List<string>();
    }

    public void AddTag(string tag)
    {
        Tags.Add(tag);
    }

    public override string ToString()
    {
        return $"{Date}|{Prompt}|{Response}|{string.Join(",", Tags)}";
    }
}

