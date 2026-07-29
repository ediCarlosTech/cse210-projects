using System;
using System.Net.WebSockets;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("This is the OnlineOrdering Project.\n");

        Address address = new Address("up and down", "Happiness", "TheProvince", "USA");

        Address address1 = new Address("the fast up and down", "The Super Province", "the biggest Province", "Brazil");

        Product product = new Product("Healthy Water", 1, 10.25, 10);
        Product product1 = new Product("Rice", 2, 25, 20);
        Product product2 = new Product("Milk", 3, 20.44, 44);

        Customer customer = new Customer("João da Silva", address);
        Customer customer1 = new Customer("Maria", address1);

        Order order1 = new Order(customer);

        order1.AddProducts(product);
        order1.AddProducts(product1);
        order1.AddProducts(product2);

        System.Console.WriteLine("Order information: \n");
        System.Console.WriteLine(order1.GetPackingLabel());
        System.Console.WriteLine(order1.GetShippingLabel());
        System.Console.WriteLine($"Total Price of the order: {order1.GetOrderTotalCost()}");

        Order order2 = new Order(customer1);

        order2.AddProducts(product2);
        order2.AddProducts(product1);

        System.Console.WriteLine("Order information: \n");
        System.Console.WriteLine(order2.GetPackingLabel());
        System.Console.WriteLine(order2.GetShippingLabel());
        System.Console.WriteLine($"Total Price of the order: {order2.GetOrderTotalCost()}");


    }
}