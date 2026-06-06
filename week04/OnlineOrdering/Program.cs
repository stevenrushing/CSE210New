using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("123 Main St", "Springfield", "IL", "USA");
        Customer customer1 = new Customer("John Smith", address1);

        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Notebook", "72", 2.50, 3));
        order1.AddProduct(new Product("Pencil Pack", "14", 1.99, 2));
        order1.AddProduct(new Product("Stapler", "305", 7.00, 1));

        Console.WriteLine("Order 1:");
        Console.WriteLine("Packing Label:");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine("Total: $" + order1.GetTotalCost());

        Console.WriteLine();

        Address address2 = new Address("456 Maple Ave", "Toronto", "ON", "Canada");
        Customer customer2 = new Customer("Emily Chen", address2);

        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Water Bottle", "88", 12.99, 1));
        order2.AddProduct(new Product("Sticky Notes", "203", 3.49, 2));

        Console.WriteLine("Order 2:");
        Console.WriteLine("Packing Label:");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine("Total: $" + order2.GetTotalCost());
    }
}
