using System.IO;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Unicode;



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
            entry.Display();
        }
    }

    public void SaveToFile(string file, List<Entry> entries)
    {

        var options = new JsonSerializerOptions { WriteIndented = true, IncludeFields = true };
        var json = JsonSerializer.Serialize(entries, options);
        File.WriteAllText(file, json);
    }

    public void LoadFromFile(string file, List<Entry> entries)
    {

        if (!File.Exists(file)) return;

        try
        {
            var options = new JsonSerializerOptions
            {
                IncludeFields = true,
                Encoder = JavaScriptEncoder.Create(UnicodeRanges.All)
            };

            var json = File.ReadAllText(file);
            var loaded = JsonSerializer.Deserialize<List<Entry>>(json, options);

            if (loaded == null) return;

            entries.Clear();
            entries.AddRange(loaded);
        }
        catch (Exception ex)
        {
            System.Console.WriteLine($"Error loading JSON file: {ex.Message}");
        }

    }
}