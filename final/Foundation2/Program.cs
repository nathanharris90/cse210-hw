using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Product product1 = new Product("Laptop", "P01", 1200.0, 2);
        Product product2 = new Product("Mouse", "P02", 25.0, 3);
        Product product3 = new Product("Headphones", "P03", 50.0, 1);

        Address usaAddress = new Address("555 Mikan Drive", "Rexburg", "ID", "USA");
        Address nonUsaAddress = new Address("1832 Main Street", "Mexico City", "Mexico City", "Mexico");

        Customer usaCustomer = new Customer("Billy Joe", usaAddress);
        Customer nonUsaCustomer = new Customer("Mackenzie Hubble", nonUsaAddress);

        Order order1 = new Order(usaCustomer);
        order1.AddProduct(product1);
        order1.AddProduct(product2);
        order1.AddProduct(product3);

        Order order2 = new Order(nonUsaCustomer);
        order2.AddProduct(product1);
        order2.AddProduct(product3);

        DisplayOrderInformation(order1);
        DisplayOrderInformation(order2);
    }

    static void DisplayOrderInformation(Order order)
    {
        Console.WriteLine($"Packing Label:\n{order.GetPackingLabel()}\n");
        Console.WriteLine($"Shipping Label:\n{order.GetShippingLabel()}\n");
        Console.WriteLine($"Total Price: ${order.GetTotalPrice()}\n");
    }
}



