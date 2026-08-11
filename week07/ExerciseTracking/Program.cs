using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();

        activities.Add(new Running("11 Ago 2026", 40, 4.0));
        activities.Add(new Cycling("11 Ago 2026", 40, 12.0));
        activities.Add(new Swimming("11 Ago 2026", 35, 30));

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}