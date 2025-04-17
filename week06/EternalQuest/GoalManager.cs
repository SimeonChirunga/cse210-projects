using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

public class GoalManager
{
    private List<Goal> _goals;
    private int _score;

    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }


    public void Start()
    {
        while (true)
        {
            Console.WriteLine("1. Display player info");
            Console.WriteLine("2. List goal names");
            Console.WriteLine("3. List goal details");
            Console.WriteLine("4. Create goal");
            Console.WriteLine("5. Record event");
            Console.WriteLine("6. Save goals");
            Console.WriteLine("7. Load goals");
            Console.WriteLine("8. Exit");

            Console.Write("Choose an option: ");
            int option = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 1:
                    DisplayPlayerInfo();
                    break;
                case 2:
                    ListGoalNames();
                    break;
                case 3:
                    ListGoalDetails();
                    break;
                case 4:
                    CreateGoal();
                    break;
                case 5:
                    RecordEvent();
                    break;
                case 6:
                    SaveGoals();
                    break;
                case 7:
                    LoadGoals();
                    break;
                case 8:
                    return;
                default:
                    Console.WriteLine("Invalid option. Please choose a valid option.");
                    break;
            }
        }
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"Current score: {_score}");
    }

    public void ListGoalNames()
    {
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i]._name}");
        }
    }

    public void ListGoalDetails()
    {
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetStringRepresentation()}");
        }
    }

    public void CreateGoal()
    {
        Console.Write("Enter goal type (1 = Simple, 2 = Eternal, 3 = Checklist): ");
        int goalType = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter goal name: ");
        string name = Console.ReadLine();

        Console.Write("Enter goal description: ");
        string description = Console.ReadLine();


        Console.Write("Enter goal points: ");
        int points = Convert.ToInt32(Console.ReadLine());

        Goal goal;
        switch (goalType)
        {
            case 1:
                goal = new SimpleGoal(name, description, points);
                break;
            case 2:
                goal = new EternalGoal(name, description, points);
                break;
            case 3:
                Console.Write("Enter target count: ");
                int target = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter bonus points: ");
                int bonus = Convert.ToInt32(Console.ReadLine());
                goal = new GoalChecklist(name, description, points, target, bonus);
                break;
            default:
                Console.WriteLine("Invalid goal type.");
                return;
        }

        _goals.Add(goal);
    }

    public void RecordEvent()
    {
        ListGoalNames();
        Console.Write("Enter the number of the goal you want to record: ");
        int goalIndex = Convert.ToInt32(Console.ReadLine()) - 1;

        if (goalIndex >= 0 && goalIndex < _goals.Count)
        {
            _goals[goalIndex].RecordEvent();
            _score += _goals[goalIndex]._points;
            if (_goals[goalIndex] is GoalChecklist checklistGoal && checklistGoal.IsComplete())
            {
                _score += checklistGoal._bonus;
            }
            Console.WriteLine("Event recorded.");
        }
        else
        {
            Console.WriteLine("Invalid goal number.");
        }
    }

    public void SaveGoals()
    {
        var options = new JsonSerializerOptions { WriteIndented = true };
        var json = JsonSerializer.Serialize(_goals, options);
        File.WriteAllText("goals.json", json);
        Console.WriteLine("Goals saved.");
    }

    public void LoadGoals()
    {
        if (File.Exists("goals.json"))
        {
            var json = File.ReadAllText("goals.json");
            _goals = JsonSerializer.Deserialize<List<Goal>>(json);
            Console.WriteLine("Goals loaded.");
        }
        else
        {
            Console.WriteLine("No saved goals found.");
        }
    }
}
