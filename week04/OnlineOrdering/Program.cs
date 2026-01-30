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


        // string product1 = "air compressor";
        // int productID1 = 12345678;
        // decimal priceEa1 = 279.56m;
        // int quantity1 = 1;


        // string product2 = "torque wrench";
        // int productID2 = 09876543;
        // decimal priceEa2 = 22.85m;
        // int quantity2 = 2;


        // // ORDER 2:
        Address address2 = new Address("692-B Roads End", "Frostbite Falls", "Manitoba", "Canada");
        string wholeAddress2 = address2.WholeAddress();
        bool inUSA2 = address2.AddressInUSA();
        Console.WriteLine(inUSA2);

        // string name2 = "Bulwinkle J Moose";

        // string product3 = "Mooseberries";
        // int productID3 = 26497513;
        // decimal priceEa3 = 5.45m;
        // int quantity3 = 3;


        // string product4 = "Academia Nuts";
        // int productID4 = 79431658;
        // decimal priceEa4 = 12.64m;
        // int quantity4 = 2;


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