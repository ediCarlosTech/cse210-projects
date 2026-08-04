/*
    Exceeding Requirements
    I implemented the idea of "Keeping a log of how many times activities were performed."
    and I created an option in the menu to view the history of the log.
*/

using System;

class Program
{
    static void Main(string[] args)
    {
        var option = "";

        do
        {
            System.Console.WriteLine("Menu Options:");
            Console.WriteLine("\t1. Start breathing activity");
            Console.WriteLine("\t2. Start reflecting activity");
            Console.WriteLine("\t3. Start listing activity");
            Console.WriteLine("\t4. View History");
            Console.WriteLine("\t5. Quit");
            Console.Write("Select a choice from the menu: ");
            option = Console.ReadLine();

            switch (option)
            {
                case "1":

                    BreathingActivity ba = new BreathingActivity();
                    ba.Run();
                    break;
                case "2":
                    ReflectingActivity ra = new ReflectingActivity();
                    ra.Run();
                    break;
                case "3":
                    ListingActivity la = new ListingActivity();
                    la.Run();
                    break;
                case "4":
                    ViewLog();
                    break;
                case "5":
                    Console.Clear();
                    System.Console.WriteLine("Getting out");
                    return;
                default:
                    Console.WriteLine("Wrong option. Please try again.\n");
                    break;

            }

        } while (option != "5");
    }

    private static void ViewLog()
    {
        Console.Clear();
        Console.WriteLine("--- Activity History ---");
        if (File.Exists("activity_log.txt"))
        {
            string content = File.ReadAllText("activity_log.txt");
            Console.WriteLine(content);
        }
        else
        {
            Console.WriteLine("No activities logged yet.");
        }
        Console.WriteLine("\nPress Enter to return to menu...");
        Console.ReadLine();
    }
}