using System.Collections.Generic;

public class GoalManager
{
    private List<Goal> _goals;
    private int _score;

    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }

    public void DisplayPlayerInfo()
    {
        string level;
        if (_score >= 10000)
        {
            level = "Legend";
        }
        else if (_score >= 5000)
        {
            level = "Champion";
        }
        else if (_score >= 2000)
        {
            level = "Hero";
        }
        else if (_score >= 500)
        {
            level = "Adventurer";
        }
        else
        {
            level = "Beginner";
        }

        Console.WriteLine($"You are a {level} with {_score} points.");
    }

    public void ListGoalNames()
    {
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].ShortName}");
        }
    }

    public void ListGoalDetails()
    {
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetDetailsString()}");
        }
    }

    public void CreateGoal()
    {
        Console.WriteLine("What type of goal would you like to create?");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.Write("Select a choice: ");
        string goalType = Console.ReadLine();

        Console.Write("What is the name of your goal? ");
        string name = Console.ReadLine();

        Console.Write("What is a short description of your goal? ");
        string description = Console.ReadLine();

        Console.Write("What is the point value for this goal? ");
        int points = int.Parse(Console.ReadLine());

        if (goalType == "1")
        {
            _goals.Add(new SimpleGoal(name, description, points));
        }
        else if (goalType == "2")
        {
            _goals.Add(new EternalGoal(name, description, points));
        }
        else if (goalType == "3")
        {
            Console.Write("How many times does this goal need to be completed? ");
            int target = int.Parse(Console.ReadLine());

            Console.Write("What is the bonus point value when the goal is complete? ");
            int bonus = int.Parse(Console.ReadLine());

            _goals.Add(new ChecklistGoal(name, description, points, target, bonus));
        }
    }

    public void RecordEvent()
    {
        Console.WriteLine("Which goal did you complete?");
        ListGoalNames();

        Console.Write("Enter the number: ");
        int index = int.Parse(Console.ReadLine()) - 1;

        bool wasComplete = _goals[index].IsComplete();
        int pointsEarned = _goals[index].RecordEvent();
        _score += pointsEarned;

        Console.WriteLine($"You earned {pointsEarned} points! Total score: {_score}");

        if (!wasComplete && _goals[index].IsComplete())
        {
            Console.WriteLine("Congratulations! You have completed this goal!");
        }
    }

    public void SaveGoals()
    {
        Console.Write("What is the filename for the save file? ");
        string filename = Console.ReadLine();

        using (System.IO.StreamWriter outputFile = new System.IO.StreamWriter(filename))
        {
            outputFile.WriteLine(_score);
            foreach (Goal goal in _goals)
            {
                outputFile.WriteLine(goal.GetStringRepresentation());
            }
        }

        Console.WriteLine("Goals saved!");
    }

    public void LoadGoals()
    {
        Console.Write("What is the filename for the save file? ");
        string filename = Console.ReadLine();

        string[] lines = System.IO.File.ReadAllLines(filename);

        int savedScore = int.Parse(lines[0]);
        _goals = new List<Goal>();

        for (int i = 1; i < lines.Length; i++)
        {
            string[] parts = lines[i].Split(":");
            string goalType = parts[0];
            string[] details = parts[1].Split(",");

            if (goalType == "SimpleGoal")
            {
                string name = details[0];
                string description = details[1];
                int points = int.Parse(details[2]);
                bool isComplete = bool.Parse(details[3]);

                SimpleGoal goal = new SimpleGoal(name, description, points);
                if (isComplete)
                {
                    goal.RecordEvent();
                }
                _goals.Add(goal);
            }
            else if (goalType == "EternalGoal")
            {
                string name = details[0];
                string description = details[1];
                int points = int.Parse(details[2]);

                _goals.Add(new EternalGoal(name, description, points));
            }
            else if (goalType == "ChecklistGoal")
            {
                string name = details[0];
                string description = details[1];
                int points = int.Parse(details[2]);
                int amountCompleted = int.Parse(details[3]);
                int target = int.Parse(details[4]);
                int bonus = int.Parse(details[5]);

                ChecklistGoal goal = new ChecklistGoal(name, description, points, target, bonus);
                for (int j = 0; j < amountCompleted; j++)
                {
                    goal.RecordEvent();
                }
                _goals.Add(goal);
            }
        }

        _score = savedScore;
        Console.WriteLine("Goals loaded!");
    }

    public void Start()
    {
        string choice = "";
        while (choice != "6")
        {
            Console.WriteLine("\nMenu:");
            Console.WriteLine("1. Create new goal");
            Console.WriteLine("2. List goals");
            Console.WriteLine("3. Record event");
            Console.WriteLine("4. Save goals");
            Console.WriteLine("5. Load goals");
            Console.WriteLine("6. Quit");
            DisplayPlayerInfo();
            Console.Write("Select a choice from the menu: ");
            choice = Console.ReadLine();

            if (choice == "1")
            {
                CreateGoal();
            }
            else if (choice == "2")
            {
                ListGoalDetails();
            }
            else if (choice == "3")
            {
                RecordEvent();
            }
            else if (choice == "4")
            {
                SaveGoals();
            }
            else if (choice == "5")
            {
                LoadGoals();
            }
        }
    }
}
