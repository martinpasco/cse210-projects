// Program.cs
using System;
using System.Collections.Generic;

public class Program
{
    public static void Main(string[] args)
    {
        
        Address address1 = new Address("123 Main St", "New York", "NY", "USA");
        Address address2 = new Address("456 Oak Rd", "Toronto", "ON", "Canada");

        
        Customer customer1 = new Customer("John Doe", address1);
        Customer customer2 = new Customer("Jane Smith", address2);

        
        Product product1 = new Product("Laptop", 1001, 1200.00m, 2);
        Product product2 = new Product("Mouse", 1002, 25.50m, 1);
        Product product3 = new Product("Keyboard", 1003, 75.00m, 1);

        
        List<Product> products1 = new List<Product> { product1, product2 };
        List<Product> products2 = new List<Product> { product3 };

        
        Order order1 = new Order(products1, customer1);
        Order order2 = new Order(products2, customer2);

        
        Console.WriteLine("Order 1:");
        Console.WriteLine("Packing Label:\n" + order1.GetPackingLabel());
        Console.WriteLine("Shipping Label:\n" + order1.GetShippingLabel());
        Console.WriteLine("Total Cost: $" + order1.GetTotalCost());

        
        Console.WriteLine("\nOrder 2:");
        Console.WriteLine("Packing Label:\n" + order2.GetPackingLabel());
        Console.WriteLine("Shipping Label:\n" + order2.GetShippingLabel());
        Console.WriteLine("Total Cost: $" + order2.GetTotalCost());
    }
}
