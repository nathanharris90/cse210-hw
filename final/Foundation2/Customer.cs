class Customer
{
    private string _name;
    private Address _address;

    public Customer(string _name, Address _address)
    {
        this._name = _name;
        this._address = _address;
    }

    public bool IsInUSA()
    {
        return _address.IsInUSA();
    }

    public string Name => _name;
    public Address Address => _address;
}