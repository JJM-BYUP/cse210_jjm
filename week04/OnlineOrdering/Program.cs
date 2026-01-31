using System;
class Program
{
    static void Main(string[] args)
    {
        
        // ORDER 1:
        Product product1a = new Product("Air Compressor", 12345678, 279.56m, 2);
        Product product1b = new Product("Torque Wrench", 09876543, 22.85m, 6);
        Product product1c = new Product("Orbital Sander", 96548325, 68.97m, 3);

        Address address1 = new Address("225 Wishing Way", "Nowhere", "Ohio", "USA");
        Customer customer1 = new Customer("Bob T Builder", address1);

        // ORDER 2:
        Product product2a = new Product("Mooseberries", 26497513, 5.45m, 3);
        Product product2b = new Product("Academia Nuts", 79431658, 12.64m, 5);
        Product product2c = new Product("Hot Chocolate", 56489125, 8.95m, 4);

        Address address2 = new Address("692 World's End", "Frostbite Falls", "Manitoba", "Canada");
        Customer customer2 = new Customer("Bulwinkle J Moose", address2);

        // DISPLAY:
        Order order1 = new Order(product1a, product1b, product1c, customer1);
        order1.ShippingLabel();
        order1.PackingLabel();
        order1.TotalOrderCost();
        Console.WriteLine();

        Order order2 = new Order(product2a, product2b, product2c, customer2);
        order2.ShippingLabel();
        order2.PackingLabel();
        order2.TotalOrderCost();
        Console.WriteLine();

    }

}