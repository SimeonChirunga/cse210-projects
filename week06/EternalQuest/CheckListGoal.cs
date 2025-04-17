public class GoalChecklist : Goal
{
    private int _amountCompleted;
    private int _target;
    public int _bonus;
    private bool _IsCompleted = false;

   public GoalChecklist(string name, string description, int points, int target, int bonus) : base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
        _amountCompleted = 0;
    }



    public override void RecordEvent()
    {
        _amountCompleted++;
        if (_amountCompleted >= _target)
        {
            _IsCompleted = true;
        }
    }

    public override bool IsComplete()
    {
        return _IsCompleted;
    }

   public override string GetDetailsString()
    {
        string checkbox = _IsCompleted ? "[X]" : "[ ]";
        return $"{checkbox} {_name} ({_amountCompleted}/{_target}) ({_points} points)";
    }




    public override string GetStringRepresentation()
    {
        if (_IsCompleted)
        {
            return $"[X] {_name} ({_target}/{_target})";
        }
        else
        {
            return $"[ ] {_name} ({_amountCompleted}/{_target})";
        }
    }
}

