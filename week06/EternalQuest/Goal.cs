
// Base class for all goals
public abstract class Goal
{
    public string _name;
    public int _points;
    protected string _description;
    protected bool _isCompleted;

    public Goal() { }


    public Goal(string name, string description, int points)
    {
        _name = name;
        _points = points;
        _description = description;
        _isCompleted = false;
    }

        public abstract void RecordEvent();

    public abstract bool IsComplete();

  public virtual string GetDetailsString()
{
    string checkbox = IsComplete() ? "[X]" : "[ ]";
    return $"{checkbox} {_name} - {_description}";
}



    public abstract string GetStringRepresentation();
}



