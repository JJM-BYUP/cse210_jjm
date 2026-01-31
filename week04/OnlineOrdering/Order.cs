using System;

public class Order
{

    private Product _product1;
    private Product _product2;
    private Customer _customer;
    private decimal _shippingUSA = 5.00m;
    private decimal _shippingNotUSA = 35.00m;

    public List<Product> _products = new List<Product>();

    // Constructors
    public Order(Product product1, Product product2, Customer customer)
    {
        _product1 = product1;
        _product2 = product2;
        _customer = customer;
    }

    // Methods
    public decimal USShipping()
    {
        bool inUS = _customer.GetInUSA();
        if (inUS == true)
        {
            return _shippingUSA;
        }
        else if (inUS == false)
        {
            return _shippingNotUSA;
        }
        else
        {
            Console.WriteLine("Something's not right...");
            return 0m;
        }

    }

    public void TotalOrderCost()
    {
        // Return total cost of order: (TotaItemCost() for each item added together for a total) + shipping
        decimal itemsCost = _product1.TotalItemsCost();
        decimal itemsCost2 = _product2.TotalItemsCost();
        decimal allItemsCost = itemsCost + itemsCost2;
        decimal shipping = USShipping();
        decimal totalCost = allItemsCost + shipping;

        Console.WriteLine($"Subotal for all items ordered:          ${allItemsCost}");
        Console.WriteLine($"Shipping cost:                          $ {shipping}");
        Console.WriteLine("________________________________________________");
        Console.WriteLine("TOTAL COST");
        Console.WriteLine($"Total cost of order:                    ${totalCost}");
        Console.WriteLine();
    }

    public void PackingLabel()
    {
        string productName = _product1.ProductName;
        int productId = _product1.ProductID;
        int howMany = _product1.ProductQuant;
        decimal priceEa = _product1.ProductPriceEa;
        string productName2 = _product2.ProductName;
        int productId2 = _product2.ProductID;
        int howMany2 = _product2.ProductQuant;
        decimal priceEa2 = _product2.ProductPriceEa;

        Console.WriteLine("***********************************************");
        Console.WriteLine("PACKING LABEL");
        Console.WriteLine("***********************************************");
        Console.WriteLine($"{productName} . . . . . . . . . . {productId}");
        Console.WriteLine($"Number of items:                   {howMany}");
        Console.WriteLine($"Price for each:                    ${priceEa}");
        Console.WriteLine();
        Console.WriteLine($"{productName2} . . . . . . . . . . {productId2}");
        Console.WriteLine($"Number of items:                   {howMany2}");
        Console.WriteLine($"Price for each:                    ${priceEa2}");
        Console.WriteLine();
        Console.WriteLine("________________________________________________");
    }

    public void ShippingLabel()
    {
        string custName = _customer.CustomerName;
        string address = _customer.GetAddress();

        Console.WriteLine("******************");
        Console.WriteLine("SHIPPING LABEL:");
        Console.WriteLine("******************");
        Console.WriteLine();
        Console.WriteLine(custName);
        Console.WriteLine(address);
        Console.WriteLine();
    }
}