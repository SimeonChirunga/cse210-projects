// This program also adds tags for each entry. The user can filter entries by tag.
// The user can also save the journal to a file and load the journal from a file.
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Journal Project.");


        var journal = new Journal();
        var promptGenerator = new PromptGenerator();

        while (true)
        {
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Save the journal to a file");
            Console.WriteLine("4. Load the journal from a file");
            Console.WriteLine("5. Filter entries by tag");
            Console.WriteLine("6. Exit");

            Console.Write("Choose an option: ");
            var option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    WriteNewEntry(journal, promptGenerator);
                    break;
                case "2":
                    DisplayJournal(journal);
                    break;
                case "3":
                    SaveJournalToFile(journal);
                    break;
                case "4":
                    LoadJournalFromFile(journal);
                    break;
                case "5":
                    FilterEntriesByTag(journal);
                    break;
                case "6":
                    return;
                default:
                    Console.WriteLine("Invalid option. Please choose again.");
                    break;
            }
        }
    }

    static void FilterEntriesByTag(Journal journal)
    {
        Console.Write("Enter a tag to filter by: ");
        var tag = Console.ReadLine();
        var entries = journal.GetEntriesByTag(tag);
        foreach (var entry in entries)
        {
            Console.WriteLine(entry.ToString());
        }

    }

    static void WriteNewEntry(Journal journal, PromptGenerator promptGenerator)
    {
        var prompt = promptGenerator.GetRandomPrompt();
        Console.WriteLine($"Prompt: {prompt}");
        Console.Write("Response: ");
        var response = Console.ReadLine();

        Console.Write("Enter tags (comma-separated): ");
        var tags = Console.ReadLine().Split(',');

        var entry = new Entry(DateTime.Now.ToString(), prompt, response);
        foreach (var tag in tags)
        {
            entry.AddTag(tag.Trim());
        }

        journal.AddEntry(entry);
    }


    static void DisplayJournal(Journal journal)
    {
        journal.DisplayEntries();
    }

    static void SaveJournalToFile(Journal journal)
    {
        Console.Write("Enter filename: ");
        var filename = Console.ReadLine();
        journal.SaveToFile(filename);
    }

    static void LoadJournalFromFile(Journal journal)
    {
        Console.Write("Enter filename: ");
        var filename = Console.ReadLine();
        journal.LoadFromFile(filename);
    }
}



