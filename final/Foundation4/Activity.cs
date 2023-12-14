public class Activity
{
    protected DateTime _date;
    protected int _minutes;

    public Activity(DateTime date, int minutes)
    {
        _date = date;
        _minutes = minutes;
    }

    public virtual double GetDistance()
    {
        return 0;
    }

    public virtual double GetSpeed()
    {
        return 0;
    }

    public virtual double GetPace()
    {
        return 0;
    }

    public virtual string GetDistanceUnit()
    {
        return "units";
    }

    public virtual string GetSpeedUnit()
    {
        return "units/h";
    }

    public virtual string GetPaceUnit()
    {
        return "min/units";
    }

    public virtual string GetSummary()
    {
        return $"{_date:dd MMM yyyy} ({GetType().Name}) - {GetFormattedActivityLength()}, Distance: {GetDistance()} {GetDistanceUnit()}, Speed: {GetSpeed()} {GetSpeedUnit()}, Pace: {GetPace()} {GetPaceUnit()}";
    }

    protected string GetFormattedActivityLength()
    {
        return $"{_minutes} min";
    }
}