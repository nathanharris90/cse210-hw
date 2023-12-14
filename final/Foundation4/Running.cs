public class Running : Activity
{
    private double _distance;

    public Running(DateTime date, int minutes, double distance)
        : base(date, minutes)
    {
        _distance = distance;
    }

    public override double GetDistance()
    {
        return _distance;
    }

    public override double GetSpeed()
    {
        return (_distance / _minutes) * 60;
    }

    public override double GetPace()
    {
        return _minutes / _distance;
    }

    public override string GetDistanceUnit()
    {
        return "miles";
    }

    public override string GetSpeedUnit()
    {
        return "mph";
    }

    public override string GetPaceUnit()
    {
        return "min/mile";
    }
}