public class Running : Activity
{
    private double _distanceInKm;

    public Running(DateTime date, int lengthInMinutes, double distanceInKm) : base(date, lengthInMinutes)
    {
        _distanceInKm = distanceInKm;
    }

    public override double GetDistance()
    {
        return _distanceInKm;
    }

    public override double GetSpeed()
    {
        return (_distanceInKm / _lengthInMinutes) * 60;
    }

    public override double GetPace()
    {
        return _lengthInMinutes / _distanceInKm;
    }
}
