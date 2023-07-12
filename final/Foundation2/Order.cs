class Order
{
    public List<Product> Products { get; }
    public Customer Customer { get; set; }

    public Order()
    {
        Products = new List<Product>();
    }

    public void AddProduct(Product product)
    {
        Products.Add(product);
    }

    public double CalculateTotalCost()
    {
        double totalCost = 0;

        foreach (Product product in Products)
        {
            totalCost += product.Price * product.Quantity;
        }

        if (Customer.Address.IsInUSA())
        {
            totalCost += 5;
        }
        else
        {
            totalCost += 35;
        }

        return totalCost;
    }

    public string GetPackingLabel()
    {
        string packingLabel = "";

        foreach (Product product in Products)
        {
            packingLabel += $"Product: {product.Name}, Product ID: {product.ProductID}\n";
        }

        return packingLabel;
    }

    public string GetShippingLabel()
    {
        return $"Customer Name: {Customer.Name}\nAddress: {Customer.Address.GetFullAddress()}";
    }
}