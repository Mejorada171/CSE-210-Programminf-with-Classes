class Program 
{
    static void Main(string[] args) 
    {
        Address _address1 = new Address("346 Main St", "San Francisco", "CA", "USA");
        Customer _customer1 = new Customer("John Doe", _address1);

        Product _product1 = new Product("Widget", 3325, 1.99m, 2);
        Product _product2 = new Product("Gizmo", 9983, 2.49m, 1);
        Product[] _products1 = { _product1, _product2 };
        Order _order1 = new Order(_products1, _customer1);

        Console.WriteLine("Order 1");
        Console.WriteLine("-------");
        Console.WriteLine("Packing Label:");
        Console.WriteLine(_order1.GetPackingLabel());
        Console.WriteLine("Shipping Label:");
        Console.WriteLine(_order1.GetShippingLabel());
        Console.WriteLine($"Total price: ${_order1.GetTotalPrice()}\n");

        Address _address2 = new Address("456 Oak St", "North York", "ON", "Canada");
        Customer _customer2 = new Customer("Jane Smith", _address2);

        Product _product3 = new Product("Dress", 9826, 1.20m, 1);
        Product _product4 = new Product("Earings", 9983, 2.49m, 3);
        Product[] _products2 = { _product3, _product4 };
        Order _order2 = new Order(_products2, _customer2);

        Console.WriteLine("Order 2");
        Console.WriteLine("-------");
        Console.WriteLine("Packing Label:");
        Console.WriteLine(_order2.GetPackingLabel());
        Console.WriteLine("Shipping Label:");
        Console.WriteLine(_order2.GetShippingLabel());
        Console.WriteLine($"Total price: ${_order2.GetTotalPrice()}\n");
    }
}
