public abstract class Activity
{
    protected DateTime _date;
    protected int _lengthInMinutes;

    public Activity(DateTime date, int lengthInMinutes)
    {
        _date = date;
        _lengthInMinutes = lengthInMinutes;
    }

    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();

    public virtual string GetSummary()
    {
        string activityType = this.GetType().Name;
        double distance = GetDistance();
        double speed = GetSpeed();
        double pace = GetPace();

        return $"{_date.ToString("dd MMM yyyy")} {activityType} ({_lengthInMinutes} min) - Distance: {distance:F2} km, Speed: {speed:F2} kph, Pace: {pace:F2} min per km";
    }
}
