using System.IO;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            System.Console.WriteLine($"Date: {entry._date} - Prompt: {entry._promptText}");
            System.Console.WriteLine($"response: {entry._entryText}");
            System.Console.WriteLine();
        }
    }

    public void SaveToFile(string file, List<Entry> entries)
    {
        using (StreamWriter outputFile = new StreamWriter(file))
        {
            foreach (Entry entry in entries)
            {
                outputFile.WriteLine($"{entry._date}|{entry._promptText}|{entry._entryText}");
            }
        }
    }

    public void LoadFromFile(string file, List<Entry> entries)
    {
        string filename = file;
        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            string[] parts = line.Split("|");

            Entry entry = new Entry();

            entry._date = parts[0];
            entry._promptText = parts[1];
            entry._entryText = parts[2];

            entries.Add(entry);
        }

    }
}