using System;
using System.Collections.Generic;

public class Journal
{
    public List<Entry> Entries { get; set; }

    public Journal()
    {
        Entries = new List<Entry>();
    }

    public void AddEntry(Entry entry)
    {
        Entries.Add(entry);
    }

    public void DisplayEntries()
    {
        foreach (var entry in Entries)
        {
            Console.WriteLine(entry.ToString());
        }
    }

    public void SaveToFile(string filename)
    {
        using (var writer = new System.IO.StreamWriter(filename))
        {
            foreach (var entry in Entries)
            {
                writer.WriteLine(entry.ToString());
            }
        }
    }

    public void LoadFromFile(string filename)
    {
        Entries.Clear();
        using (var reader = new System.IO.StreamReader(filename))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                var parts = line.Split('|');
                var entry = new Entry(parts[0], parts[1], parts[2]);
                var tags = parts[3].Split(',');
                foreach (var tag in tags)
                {
                    entry.AddTag(tag);
                }
                Entries.Add(entry);
            }
        }
    }

    public List<Entry> GetEntriesByTag(string tag)
    {
        return Entries.Where(e => e.Tags.Contains(tag)).ToList();
    }


}



