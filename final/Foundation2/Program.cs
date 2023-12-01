using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("1234 S Main", "Detroit", "Michigan", "USA");
        Customer customer1 = new Customer("Missionary Master", address1);
        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Book of Mormon", 1, 3, 15));
        order1.AddProduct(new Product("Passalong Cards (50 pack)", 2, 2, 2));
        order1.AddProduct(new Product("Joseph Smith Pamphlets (10 pack)", 3, 3, 10));

        Console.WriteLine("Shipping Label");
        Console.WriteLine(order1.ShippingLabel());
        Console.WriteLine("");

        Console.WriteLine("Packing Label");
        order1.PackingLabel();
        Console.WriteLine("");

        Console.WriteLine($"The total price of order is ${order1.OrderTotal()}");
        Console.WriteLine("");


        Address address2 = new Address("567 Celestial Street", "Heaven City", "Paris", "France");
        Customer customer2 = new Customer("Sister Serious", address2);
        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Book of Mormon", 1, 3, 30));
        order2.AddProduct(new Product("Passalong Cards (50 pack)", 2, 2, 4));
        order2.AddProduct(new Product("Picture of Jesus Christ", 4, 1, 20));

        Console.WriteLine("Shipping Label");
        Console.WriteLine(order2.ShippingLabel());
        Console.WriteLine("");
        Console.WriteLine("");


        Console.WriteLine("Packing Label");
        order2.PackingLabel();
        Console.WriteLine("");

        Console.WriteLine($"The total price of order is ${order2.OrderTotal()}");
        Console.WriteLine("");
        Console.WriteLine("");

    }
}