using System;

class Program
{
    static void Main(string[] args)
    {
        string choice = "";
        Journal journal = new Journal();
        Console.WriteLine("Welcome to the Journal Program!");

        while (choice != "5")
        {
            System.Console.WriteLine("Please select one of the following choices:");
            System.Console.WriteLine("1. Write");
            System.Console.WriteLine("2. Display");
            System.Console.WriteLine("3. Load");
            System.Console.WriteLine("4. Save");
            System.Console.WriteLine("5. Quit");

            System.Console.Write("What would you like to do? ");
            choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    PromptGenerator promptGenerator = new PromptGenerator();
                    Entry entry = new Entry();
                    entry._promptText = promptGenerator.GetRandomPrompt();
                    System.Console.Write($"{entry._promptText} ");
                    entry._entryText = Console.ReadLine();

                    DateTime theCurrentTime = DateTime.Now;
                    entry._date = theCurrentTime.ToShortDateString();

                    journal.AddEntry(entry);
                    break;

                case "2":
                    journal.DisplayAll();
                    break;

                case "3":
                    System.Console.Write("What is the file name? ");
                    string fileNameToLoad = Console.ReadLine();
                    journal.LoadFromFile(fileNameToLoad, journal._entries);
                    break;

                case "4":
                    System.Console.Write("What is the file name? ");
                    string fileNameToSave = Console.ReadLine();
                    journal.SaveToFile(fileNameToSave, journal._entries);
                    break;

                case "5":
                    System.Console.WriteLine("Bye bye");
                    break;

                default:
                    System.Console.WriteLine("Wrong option");
                    break;
            }
        }

    }
}