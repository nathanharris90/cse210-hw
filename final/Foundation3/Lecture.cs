public class Lecture : Event
{
    private string _speaker;
    private int _capacity;

    public Lecture(string title, string description, string date, string time, Address address, string speaker, int capacity)
        : base(title, description, date, time, address)
    {
        _speaker = speaker;
        _capacity = capacity;
    }

    public override string StandardDetails()
    {
        return $"Title: {_title}, Date: {_date}, Time: {_time}, Address: {_address._street}, {_address._city}, {_address._state}, {_address._zipCode}";
    }

    public override string FullDetails()
    {
        return $"{StandardDetails()}, Type: Lecture, Speaker: {_speaker}, Capacity: {_capacity}";
    }

    public override string ShortDescription()
    {
        return $"Lecture - {_title}, Date: {_date}";
    }
}