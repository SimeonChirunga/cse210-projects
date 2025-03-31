using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the OnlineOrdering Project.");

            // Create customers
            Address address1 = new Address("123 Main St", "Anytown", "CA", "USA");
            Customer customer1 = new Customer("John Doe", address1);

            Address address2 = new Address("456 Elm St", "Othertown", "ON", "Canada");
            Customer customer2 = new Customer("Jane Smith", address2);

            // Create products
            Product product1 = new Product("Widget", "WID-001", 19.99m, 2);
            Product product2 = new Product("Gadget", "GAD-002", 9.99m, 3);
            Product product3 = new Product("Thingamajig", "THI-003", 29.99m, 1);

            // Create orders
            Order order1 = new Order(customer1);
            order1.AddProduct(product1);
            order1.AddProduct(product2);

            Order order2 = new Order(customer2);
            order2.AddProduct(product2);
            order2.AddProduct(product3);

            // Display order information
            Console.WriteLine("Order 1:");
            Console.WriteLine("Packing Label:");
            Console.WriteLine(order1.GetPackingLabel());
            Console.WriteLine("Shipping Label:");
            Console.WriteLine(order1.GetShippingLabel());
            Console.WriteLine("Total Cost: $" + order1.GetTotalCost());

            Console.WriteLine();

            Console.WriteLine("Order 2:");
            Console.WriteLine("Packing Label:");
            Console.WriteLine(order2.GetPackingLabel());
            Console.WriteLine("Shipping Label:");
            Console.WriteLine(order2.GetShippingLabel());
            Console.WriteLine("Total Cost: $" + order2.GetTotalCost());
        }
    }


