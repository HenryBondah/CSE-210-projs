using System;

class Program
{
    static void Main()
    {
        Product product1 = new Product("Product 1", "12345", 10, 2);
        Product product2 = new Product("Product 2", "67890", 15, 3);

        Address address1 = new Address("123 Main St", "City1", "State1", "USA");
        Customer customer1 = new Customer("John Doe", address1);

        Address address2 = new Address("456 Elm St", "City2", "State2", "Canada");
        Customer customer2 = new Customer("Jane Smith", address2);

        Order order1 = new Order();
        order1.AddProduct(product1);
        order1.AddProduct(product2);
        order1.Customer = customer1;

        Order order2 = new Order();
        order2.AddProduct(product2);
        order2.Customer = customer2;

        Console.WriteLine("Order 1:");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total cost: ${order1.CalculateTotalCost()}");

        Console.WriteLine();

        Console.WriteLine("Order 2:");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total cost: ${order2.CalculateTotalCost()}");
    }
}