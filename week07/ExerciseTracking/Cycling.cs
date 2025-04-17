public class Cycling : Activity
{
    private double _averageSpeedInKph;

    public Cycling(DateTime date, int lengthInMinutes, double averageSpeedInKph) : base(date, lengthInMinutes)
    {
        _averageSpeedInKph = averageSpeedInKph;
    }

    public override double GetDistance()
    {
        return (_averageSpeedInKph / 60) * _lengthInMinutes;
    }

    public override double GetSpeed()
    {
        return _averageSpeedInKph;
    }

    public override double GetPace()
    {
        return 60 / _averageSpeedInKph;
    }
}
