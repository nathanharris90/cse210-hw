public class Reception : Event
{
    private string _rsvpEmail;

    public Reception(string title, string description, string date, string time, Address address, string rsvpEmail)
        : base(title, description, date, time, address)
    {
        _rsvpEmail = rsvpEmail;
    }

    public override string StandardDetails()
    {
        return $"Title: {_title}, Date: {_date}, Time: {_time}, Address: {_address._street}, {_address._city}, {_address._state}, {_address._zipCode}";
    }

    public override string FullDetails()
    {
        return $"{StandardDetails()}, Type: Reception, RSVP Email: {_rsvpEmail}";
    }

    public override string ShortDescription()
    {
        return $"Reception - {_title}, Date: {_date}";
    }
}