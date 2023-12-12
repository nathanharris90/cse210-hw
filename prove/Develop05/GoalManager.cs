public class GoalManager
{
    private List<Goal> _goals;
    private int _score;

    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
        LoadGoals();
    }

    public void Start()
    {
        while (true)
        {
            Console.WriteLine("1. Display Player Info");
            Console.WriteLine("2. List Goal Names");
            Console.WriteLine("3. List Goal Details");
            Console.WriteLine("4. Create Goal");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Save Goals");
            Console.WriteLine("7. Exit");

            Console.Write("Select an option: ");
            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    DisplayPlayerInfo();
                    break;
                case "2":
                    ListGoalNames();
                    break;
                case "3":
                    ListGoalDetails();
                    break;
                case "4":
                    CreateGoal();
                    break;
                case "5":
                    RecordEvent();
                    break;
                case "6":
                    SaveGoals();
                    break;
                case "7":
                    SaveGoals();
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid option. Try again.");
                    break;
            }
        }
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"Current Score: {_score}");
    }

    public void ListGoalNames()
    {
        Console.WriteLine("Goal Names:");
        foreach (var goal in _goals)
        {
            Console.WriteLine(goal._shortName);
        }
    }

    public void ListGoalDetails()
    {
        Console.WriteLine("Goal Details:");
        foreach (var goal in _goals)
        {
            Console.WriteLine(goal.GetDetailsString());
        }
    }

    public void CreateGoal()
    {
        Console.Write("Enter goal type (Simple, Eternal, Checklist): ");
        string goalType = Console.ReadLine();

        Console.Write("Enter goal name: ");
        string name = Console.ReadLine();

        Console.Write("Enter goal description: ");
        string description = Console.ReadLine();

        Console.Write("Enter goal points: ");
        int points = int.Parse(Console.ReadLine());

        switch (goalType.ToLower())
        {
            case "simple":
                _goals.Add(new SimpleGoal(name, description, points));
                break;
            case "eternal":
                _goals.Add(new EternalGoal(name, description, points));
                break;
            case "checklist":
                Console.Write("Enter checklist target: ");
                int target = int.Parse(Console.ReadLine());

                Console.Write("Enter checklist bonus: ");
                int bonus = int.Parse(Console.ReadLine());

                _goals.Add(new ChecklistGoal(name, description, points, target, bonus));
                break;
            default:
                Console.WriteLine("Invalid goal type. Goal not created.");
                break;
        }
    }

    public void RecordEvent()
    {
        Console.Write("Enter the name of the goal to record an event for: ");
        string goalName = Console.ReadLine();

        Goal goal = _goals.FirstOrDefault(g => g._shortName == goalName);

        if (goal != null)
        {
            goal.RecordEvent();
            _score += goal._points;
            Console.WriteLine($"Event recorded for {goalName}. You earned {goal._points} points.");
        }
        else
        {
            Console.WriteLine($"Goal with name {goalName} not found.");
        }
    }

    public void SaveGoals()
    {
        using (StreamWriter writer = new StreamWriter("goals.txt"))
        {
            foreach (var goal in _goals)
            {
                writer.WriteLine(goal.GetStringRepresentation());
            }
        }

        Console.WriteLine("Goals saved successfully.");
    }

    public void LoadGoals()
    {
        try
        {
            if (File.Exists("goals.txt"))
            {
                using (StreamReader reader = new StreamReader("goals.txt"))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] parts = line.Split(',');

                        string type = parts[0];
                        string name = parts[1];
                        string description = parts[2];
                        int points = int.Parse(parts[3]);

                        switch (type.ToLower())
                        {
                            case "simple":
                                _goals.Add(new SimpleGoal(name, description, points));
                                break;
                            case "eternal":
                                _goals.Add(new EternalGoal(name, description, points));
                                break;
                            case "checklist":
                                int amountCompleted = int.Parse(parts[4]);
                                int target = int.Parse(parts[5]);
                                int bonus = int.Parse(parts[6]);
                                bool isComplete = bool.Parse(parts[7]);

                                ChecklistGoal checklistGoal = new ChecklistGoal(name, description, points, target, bonus);
                                checklistGoal.LoadState(amountCompleted, isComplete);
                                _goals.Add(checklistGoal);
                                break;
                            default:
                                Console.WriteLine($"Invalid goal type '{type}' in the file. Skipping.");
                                break;
                        }
                    }
                }

                Console.WriteLine("Goals loaded successfully.");
            }
            else
            {
                Console.WriteLine("No saved goals found.");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error loading goals: {ex.Message}");
        }
    }
}