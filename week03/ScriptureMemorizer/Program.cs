using System;

class Program
{
    static void Main(string[] args)
    {
        // Proverbs 3:5-6 Trust in the Lord with all thine heart and lean not unto thine own understanding; in all thy ways acknowledge him, and he shall direct thy paths.
        Reference reference = new Reference("Proverbs", 3, 5, 6);

        Scripture scripture = new Scripture(reference, "Trust in the Lord with all thine heart and lean not unto thine own understanding; in all thy ways acknowledge him, and he shall direct thy paths.");

        while (true)
        {

            System.Console.WriteLine(scripture.GetDisplayText());
            System.Console.WriteLine();
            System.Console.WriteLine("Press enter to continue or type 'quit' to finish:");
            string input = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(input))
            {
                if (scripture.IsCompletelyHidden())
                {
                    break;
                }

                scripture.HideRandomWords(3);
                continue;
            }

            if (input.Trim().Equals("quit", StringComparison.OrdinalIgnoreCase))
            {
                System.Console.WriteLine("Getting out");
                break;
            }

            Console.Clear();
            // System.Console.WriteLine($"You typed: {input}");


        }

    }
}