class Product
{
    public string Name { get; set; }
    public string ProductID { get; set; }
    public double Price { get; set; }
    public int Quantity { get; set; }

    public Product(string name, string productID, double price, int quantity)
    {
        Name = name;
        ProductID = productID;
        Price = price;
        Quantity = quantity;
    }
}