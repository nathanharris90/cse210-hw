class Product
{
    private string _name;
    private string _productId;
    private double _pricePerUnit;
    private int _quantity;

    public Product(string _name, string _productId, double _pricePerUnit, int _quantity)
    {
        this._name = _name;
        this._productId = _productId;
        this._pricePerUnit = _pricePerUnit;
        this._quantity = _quantity;
    }

    public double GetTotalCost()
    {
        return _pricePerUnit * _quantity;
    }

    public string Name => _name;
    public string ProductId => _productId;
}
