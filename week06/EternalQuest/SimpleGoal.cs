// Simple goal that can be marked complete
public class SimpleGoal : Goal
{
    public SimpleGoal(string name, string description, int points) : base(name, description, points)
    {
        _isCompleted = false;
    }

    // public SimpleGoal(string name, string description, int points) : base(name, description, points) { }

    public override void RecordEvent()
    {
        _isCompleted = true;
    }

    public override bool IsComplete()
    {
        return _isCompleted;
    }

    public override string GetStringRepresentation()
    {
        if (_isCompleted)
        {
            return $"[X] {_name}";
        }
        else
        {
            return $"[ ] {_name}";
        }
    }
}

