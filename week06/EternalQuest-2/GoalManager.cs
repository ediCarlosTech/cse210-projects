public class GoalManager
{
    private List<Goal> _goals;

    private int _score;

    public GoalManager()
    {
        _goals = [];
        _score = 0;
    }

    public void Start()
    {
        string input = "";

        while (input != "6")
        {
            Console.WriteLine($"\n{DisplayPlayerInfo()}\n");

            Console.WriteLine("Menu Options: ");
            Console.WriteLine(" 1. Create New Goal");
            Console.WriteLine(" 2. List Goals");
            Console.WriteLine(" 3. Save Goals");
            Console.WriteLine(" 4. Load Goals");
            Console.WriteLine(" 5. Record Event");
            Console.WriteLine(" 6. Quit");
            Console.Write("Select a choice from the menu: ");

            input = Console.ReadLine() ?? "";

            switch (input)
            {
                case "1":
                    CreateGoal();
                    break;

                case "2":
                    ListGoalDetails();
                    break;

                case "3":
                    SaveGoals();
                    break;

                case "4":
                    LoadGoals();
                    break;

                case "5":
                    RecordEvent();
                    break;
            }
        }


    }

    public void RecordEvent()
    {
        ListGoalDetails();
        Console.Write("Which goal did you accomplish? ");

        if (int.TryParse(Console.ReadLine(), out int response))
        {
            if (response > 0 && response <= _goals.Count)
            {
                Goal accomplishedGoal = _goals[response - 1];
                accomplishedGoal.RecordEvent();

                _score += accomplishedGoal.GetPoints();

                Console.WriteLine($"Congratulations! You earned {accomplishedGoal.GetPoints()} points!");

                SaveGoals();
            }
            else
            {
                Console.WriteLine("Invalid Selection. Number out of range");
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a number.");
        }
    }

    public void LoadGoals()
    {
        Console.Write("What is the filename for the goal file? ");
        string filename = Console.ReadLine() ?? "";

        if (!File.Exists(filename))
        {
            Console.WriteLine("File not found.");
            return;
        }

        string[] lines = File.ReadAllLines(filename);

        _goals.Clear();

        _score = int.Parse(lines[0]);

        for (int i = 1; i < lines.Length; i++)
        {
            string[] parts = lines[i].Split(":");

            string type = parts[0].Trim();

            string[] goalsDetail = parts[1].Split("|");

            string name = goalsDetail[0].Trim();
            string description = goalsDetail[1].Trim();
            int points = int.Parse(goalsDetail[2].Trim());

            if (type == "SimpleGoal")
            {
                SimpleGoal simpleGoal = new SimpleGoal(name, description, points);
                bool wasFinished = bool.Parse(goalsDetail[3].Trim());

                if (wasFinished)
                {
                    simpleGoal.SetComplete();
                }

                _goals.Add(simpleGoal);
            }

        }

        Console.WriteLine("Goals loaded...");
    }

    public void SaveGoals()
    {
        if (_goals.Count == 0)
        {
            Console.WriteLine("Please create a goal first!");
            return;
        }

        Console.Write("What is the filename for the goal file? ");
        string filename = Console.ReadLine() ?? "";

        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            outputFile.WriteLine(_score);

            foreach (Goal goal in _goals)
            {
                outputFile.WriteLine(goal.GetStringRepresentation());
            }
        }
    }

    public string DisplayPlayerInfo()
    {
        return $"You have {_score} points";
    }

    public void CreateGoal()
    {
        Console.WriteLine("What type of goal would you like to create? ");
        Console.WriteLine(" 1. Simple Goal");
        Console.WriteLine(" 2. Eternal Goal");
        Console.WriteLine(" 3. Checklist Goal");
        Console.Write("Select a choice from the menu: ");

        string input = Console.ReadLine() ?? "";

        Console.Write("What is the name of your Goal? ");
        string title = Console.ReadLine() ?? "";

        Console.Write("What is a short description of it? ");
        string description = Console.ReadLine() ?? "";

        Console.Write("What is the amount of points associated with this goal? ");
        int points = int.Parse(Console.ReadLine());

        switch (input)
        {
            case "1":

                SimpleGoal simpleGoal = new SimpleGoal(title, description, points);
                _goals.Add(simpleGoal);

                break;

            case "2":
                EternalGoal eternalGoal = new EternalGoal(title, description, points);
                _goals.Add(eternalGoal);
                break;

            case "3":
                Console.Write("How many times does this goal need to be accompled before you get bonus points? ");
                int checklistGoalAmount = int.Parse(Console.ReadLine());

                Console.Write("What is the bonus? ");
                int bonusValue = int.Parse(Console.ReadLine());

                ChecklistGoal checklistGoal = new ChecklistGoal(title, description, points, checklistGoalAmount, bonusValue);
                _goals.Add(checklistGoal);
                break;

            default:
                Console.WriteLine("Invalid choice. Please select 1, 2 or 3.");

                break;
        }
    }

    public void ListGoalDetails()
    {
        Console.WriteLine("The goals are:");

        int i = 0;

        if (_goals.Count == 0)
        {
            Console.WriteLine("You have no goals yet.");
        }
        else
        {
            foreach (Goal goal in _goals)
            {
                Console.WriteLine($"{i + 1}. {goal.GetDetailsString()}");
                i++;
            }
        }
    }
}