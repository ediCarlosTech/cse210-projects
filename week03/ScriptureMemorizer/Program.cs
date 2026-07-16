// I prepared the code to use a list of scriptures. And I use another option in the program. The use can type the letter "s" to see the whole text again. You can see the code at line 71.

using System;

class Program
{
    static void Main(string[] args)
    {
        List<Scripture> _scriptures = new List<Scripture>();
        // Proverbs 3:5-6 Trust in the Lord with all thine heart and lean not unto thine own understanding; in all thy ways acknowledge him, and he shall direct thy paths.
        Reference reference = new Reference("Proverbs", 3, 5, 6);
        Scripture scripture = new Scripture(reference, "Trust in the Lord with all thine heart and lean not unto thine own understanding; in all thy ways acknowledge him, and he shall direct thy paths.");

        Scripture scripture2 = new Scripture(
            new Reference("Matthew", 7, 7, 8),
            "Ask, and it shall be given you; seek, and ye shall find; knock, and it shall be opened unto you: For every one that asketh receiveth; and he that seeketh findeth; and to him that knocketh it shall be opened."
        );

        _scriptures.Add(scripture);
        _scriptures.Add(scripture2);

        int index = 0;

        System.Console.WriteLine("Choose what scripture you would like to memorize:");
        System.Console.WriteLine();

        foreach (Scripture s in _scriptures)
        {
            System.Console.WriteLine($"{index + 1} - {s.GetDisplayText()}");
            System.Console.WriteLine();
            index++;
        }

        string chosenNumber = Console.ReadLine();

        Scripture scriptureChosen = _scriptures[int.Parse(chosenNumber) - 1];

        Reference referenceCopy = scriptureChosen.GetReference();
        string scriptureTextCopy = scriptureChosen.GetWords();
        Scripture scriptureCopy = new Scripture(referenceCopy, scriptureTextCopy);

        while (true)
        {
            Console.Clear();
            System.Console.WriteLine();
            System.Console.WriteLine();
            System.Console.WriteLine();

            System.Console.WriteLine(scriptureChosen.GetDisplayText());
            System.Console.WriteLine();
            System.Console.WriteLine("Press enter to continue, type 'quit' to finish, or type s to see the whole scripture again:");
            string input = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(input))
            {
                if (scriptureChosen.IsCompletelyHidden())
                {
                    break;
                }

                scriptureChosen.HideRandomWords(3);
                continue;
            }

            if (input.Trim().Equals("quit", StringComparison.OrdinalIgnoreCase))
            {
                System.Console.WriteLine("Getting out");
                break;
            }

            if (input.Trim().Equals("s", StringComparison.OrdinalIgnoreCase))
            {
                Console.Clear();
                System.Console.WriteLine();
                System.Console.WriteLine();
                System.Console.WriteLine();
                System.Console.WriteLine(scriptureCopy.GetDisplayText());
                System.Console.WriteLine();
                Console.WriteLine("Press enter to continue...");
                Console.ReadLine();
                continue;
            }

            System.Console.WriteLine();

        }

    }
}