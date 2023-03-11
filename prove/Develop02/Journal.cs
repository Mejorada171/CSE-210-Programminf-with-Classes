using System;

class Journal
{
    List<Entry> entries = new List<Entry>();

    public void DisplayJournalEntries()
    {
        foreach (Entry entry in entries)
        {
            Console.WriteLine($"{entry.date}: {entry.prompt.text}: {entry.user}");
        }
        Console.ReadLine();
    }

    public void CreateJournalEntry()
    {
        Entry yesentry = new Entry();
        Console.WriteLine($"{yesentry.prompt.text}");
        yesentry.user = Console.ReadLine();
        entries.Add(yesentry);
    }

    public void SaveToCSV()
    {
        Console.Write("Please enter a file name: ");
        string file_one = Console.ReadLine();
        using (StreamWriter stream_one = new StreamWriter(file_one))
        {
            foreach (Entry item in entries)
            {
                stream_one.WriteLine($"{item.date}: {item.prompt.text}: {item.user}");

            }
        }

    }

    public void LoadFromCSV()
    {
        Console.Write("Please enter a file name: ");
        string file_one = Console.ReadLine();
        entries.Clear();
        string[] lines = System.IO.File.ReadAllLines(file_one);
        foreach (string line in lines)
        {
            string[] parts = line.Split(": ");
            Entry newentry = new Entry();
            newentry.date = parts[0];
            newentry.prompt.text = parts[1];
            newentry.user = parts[2];
            entries.Add(newentry);
        }
    }
}