public abstract class Goal
{
    public string _shortName;
    public string _description;
    public int _points;

    public Goal(string name, string description, int points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }

    public abstract void RecordEvent();

    public abstract bool IsComplete();

    public virtual string GetDetailsString()
    {
        return $"[{(IsComplete() ? 'X' : ' ')}] {_shortName}: {_description}";
    }

    public abstract string GetStringRepresentation();
}