class Order
{
    private List<Product> products;
    private Customer _customer;

    public Order(Customer _customer)
    {
        this._customer = _customer;
        products = new List<Product>();
    }

    public void AddProduct(Product product)
    {
        products.Add(product);
    }

    public double GetTotalPrice()
    {
        double totalCost = 0;
        foreach (var product in products)
        {
            totalCost += product.GetTotalCost();
        }

        totalCost += _customer.IsInUSA() ? 5.0 : 35.0;

        return totalCost;
    }

    public string GetPackingLabel()
    {
        string packingLabel = $"Order for {_customer.Name}:\n";
        foreach (var product in products)
        {
            packingLabel += $"{product.Name} (ID: {product.ProductId})\n";
        }
        return packingLabel;
    }

    public string GetShippingLabel()
    {
        return $"Shipping to:\n{_customer.Address.GetFullAddress()}";
    }
}