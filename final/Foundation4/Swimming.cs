public class Swimming : Activity
{
    private int _laps;

    public Swimming(DateTime date, int minutes, int laps)
        : base(date, minutes)
    {
        _laps = laps;
    }

    public override double GetDistance()
    {
        return _laps * 50 / 1000;
    }

    public override double GetSpeed()
    {
        return (_laps * 50 / 1000) / (_minutes * 60);
    }

    public override double GetPace()
    {
        return _minutes / (_laps * 50 / 1000);
    }

    public override string GetDistanceUnit()
    {
        return "km";
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