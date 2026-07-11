public class Entry
{
    public string _date;
    public string _promptText;
    public string _entryText;

    public void Display()
    {
        System.Console.WriteLine($"Date: {_date} - Prompt: {_promptText}");
        System.Console.WriteLine($"response: {_entryText}");
        System.Console.WriteLine();
    }
}