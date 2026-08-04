public class BreathingActivity : Activity
{
    public BreathingActivity()
    {
        _name = "Breathing";
        _description = "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.";
    }

    public void Run()
    {
        DisplayStartingMessage();

        DateTime endDate = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < endDate)
        {
            Console.WriteLine("\nBreathe in...");
            ShowCountDown(5);

            if (DateTime.Now >= endDate)
            {
                break;
            }

            Console.WriteLine("\nBreathe out...");
            ShowCountDown(3);
        }

        Console.Clear();

        DisplayEndingMessage();
    }
}
