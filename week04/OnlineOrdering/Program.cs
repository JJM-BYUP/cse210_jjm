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
        Address address1 = new Address("225 Wishing Way", "Nowhere", "Ohio", "USA");
        string wholeAddress = address1.WholeAddress();
        bool inUSA1 = address1.AddressInUSA();
        Console.WriteLine(inUSA1);

        //Customer customer1 = new Customer("Bob T Builder", wholeAddress);

        Product product1 = new Product("Air Compressor", 12345678, 279.56m, 2);
        decimal total1 = product1.TotalCost();
        Console.WriteLine(total1);

        Product product2 = new Product("Torque Wrench", 09876543, 22.85m, 6);
        decimal total2 = product2.TotalCost();
        Console.WriteLine(total2);



        // // ORDER 2:
        Address address2 = new Address("692-B Roads End", "Frostbite Falls", "Manitoba", "Canada");
        string wholeAddress2 = address2.WholeAddress();
        bool inUSA2 = address2.AddressInUSA();
        Console.WriteLine(inUSA2);

        // string name2 = "Bulwinkle J Moose";

        Product product3 = new Product("Mooseberries", 26497513, 5.45m, 3);
        decimal total3 = product3.TotalCost();
        Console.WriteLine(total3);

        Product product4 = new Product("Academia Nuts", 79431658, 12.64m, 5);
        decimal total4 = product4.TotalCost();
        Console.WriteLine(total4);

        Product product5 = new Product("Hot Chocolate", 56489125, 8.95m, 4);
        decimal total5 = product5.TotalCost();
        Console.WriteLine(total5);


        // // PROGRAM METHODS:
        // static string PackingLabel()
        // {
        // return "";
        // }

        // static string ShippingLabel()
        // {
        // return "";
        // }

        // static decimal TotalPrice()
        // {
        // return 0;
        // }


        // // DISPLAY: results of all three methods


        // Console.WriteLine(PackingLabel());
        // Console.WriteLine(ShippingLabel());
        // Console.WriteLine(TotalPrice());


    }




}