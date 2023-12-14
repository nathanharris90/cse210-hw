public class StationaryBicycles : Activity
{
    private double _speed;

    public StationaryBicycles(DateTime date, int minutes, double speed)
        : base(date, minutes)
    {
        _speed = speed;
    }

    public override double GetSpeed()
    {
        return _speed;
    }

    public override double GetPace()
    {
        return 60 / _speed;
    }

    public override string GetSpeedUnit()
    {
        return "kph";
    }

    public override string GetPaceUnit()
    {
        return "min/km";
    }
}