public class EternalGoal : Goal
{
    private int _timesRecorded;

    public EternalGoal(string name, string description, int points)
        : base(name, description, points)
    {
        _timesRecorded = 0;
    }

    public override void RecordEvent()
    {
        _timesRecorded++;
        _points += 100;
    }

    public override bool IsComplete()
    {
        return false;
    }

    public override string GetStringRepresentation()
    {
        return $"{_shortName},{_description},{_points},{_timesRecorded}";
    }
}