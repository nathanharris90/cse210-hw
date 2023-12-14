class Address
{
    private string _streetAddress;
    private string _city;
    private string _stateProvince;
    private string _country;

    public Address(string _streetAddress, string _city, string _stateProvince, string _country)
    {
        this._streetAddress = _streetAddress;
        this._city = _city;
        this._stateProvince = _stateProvince;
        this._country = _country;
    }

    public bool IsInUSA()
    {
        return _country.ToUpper() == "USA";
    }

    public string GetFullAddress()
    {
        return $"{_streetAddress}, {_city}, {_stateProvince}, {_country}";
    }
}