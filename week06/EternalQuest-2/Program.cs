using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("\nThis is the EternalQuest-2");

        GoalManager goalManager = new GoalManager();
        goalManager.Start();
    }
}