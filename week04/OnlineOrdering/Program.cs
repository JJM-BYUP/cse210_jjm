using System;
class Program
{
    static void Main(string[] args)
    {
        /*  Have 2-3 order instances:
                CUSTOMER VALUES:
                    customer name
                    ADDRESS:
                        street, city, state/province, country
                PRODUCTS VALUES (need 2-3 products per order):
                    product name, product ID#, price for each, quantity
        */


        // ORDER 1:
        Product product1a = new Product("Air Compressor", 12345678, 279.56m, 2);
        Product product1b = new Product("Torque Wrench", 09876543, 22.85m, 6);

        Address address1 = new Address("225 Wishing Way", "Nowhere", "Ohio", "USA");
        Customer customer1 = new Customer("Bob T Builder", address1);

        Order order1 = new Order(product1a, product1b, customer1);
        order1.ShippingLabel();
        Console.WriteLine();
        Console.WriteLine();
        order1.PackingLabel();
        order1.TotalOrderCost();

        // // ORDER 2:
        // Address address2 = new Address("692 World's End", "Frostbite Falls", "Manitoba", "Canada");
        // Customer customer2 = new Customer("Bulwinkle J Moose", address2);

        // Product product2a = new Product("Mooseberries", 26497513, 5.45m, 3);
        // decimal total2b = product3.TotalCost();
        // Console.WriteLine(total3);

        // Product product4 = new Product("Academia Nuts", 79431658, 12.64m, 5);
        // decimal total4 = product4.TotalCost();
        // Console.WriteLine(total4);

        // Product product5 = new Product("Hot Chocolate", 56489125, 8.95m, 4);
        // decimal total5 = product5.TotalCost();
        // Console.WriteLine(total5);

        // Order order2 = new Order(customer2, total1);
        // order2.ShippingLabel();

    }




}