class Program 
{
    static void Main(string[] args) 
    {
        Address address1 = new Address("346 Main St", "San Francisco", "CA", "USA");
        Customer customer1 = new Customer("John Doe", address1);

        Product product1 = new Product("Widget", 3325, 1.99m, 2);
        Product product2 = new Product("Gizmo", 9983, 2.49m, 1);
        Product[] products1 = { product1, product2 };
        Order order1 = new Order(products1, customer1);

        Console.WriteLine("Order 1");
        Console.WriteLine("-------");
        Console.WriteLine("Packing Label:");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total price: ${order1.GetTotalPrice()}\n");

        Address address2 = new Address("456 Oak St", "North York", "ON", "Canada");
        Customer customer2 = new Customer("Jane Smith", address2);

        Product product3 = new Product("Dress", 9826, 1.20m, 1);
        Product product4 = new Product("Earings", 9983, 2.49m, 3);
        Product[] products2 = { product3, product4 };
        Order order2 = new Order(products2, customer2);

        Console.WriteLine("Order 2");
        Console.WriteLine("-------");
        Console.WriteLine("Packing Label:");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total price: ${order2.GetTotalPrice()}\n");
    }
}
