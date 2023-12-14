public class OutdoorGathering : Event
{
    private string _weatherForecast;

    public OutdoorGathering(string title, string description, string date, string time, Address address, string weatherForecast)
        : base(title, description, date, time, address)
    {
        _weatherForecast = weatherForecast;
    }

    public override string StandardDetails()
    {
        return $"Title: {_title}, Date: {_date}, Time: {_time}, Address: {_address._street}, {_address._city}, {_address._state}, {_address._zipCode}";
    }

    public override string FullDetails()
    {
        return $"{StandardDetails()}, Type: Outdoor Gathering, Weather Forecast: {_weatherForecast}";
    }

    public override string ShortDescription()
    {
        return $"Outdoor Gathering - {_title}, Date: {_date}";
    }
}