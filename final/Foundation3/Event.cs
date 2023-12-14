
public abstract class Event
{
    public string _title;
    public string _description;
    public string _date;
    public string _time;
    public Address _address;

    protected Event(string title, string description, string date, string time, Address address)
    {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
    }

    public abstract string StandardDetails();

    public abstract string FullDetails();

    public abstract string ShortDescription();
}
