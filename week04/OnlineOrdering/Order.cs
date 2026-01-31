using System;

public class Order
{
    private Product _product1;
    private Product _product2;
    private Product _product3;
    private Customer _customer;
    private decimal _shippingUSA = 5.00m;
    private decimal _shippingNotUSA = 35.00m;

    // Constructors
    public Order(Product product1, Product product2, Product product3, Customer customer)
    {
        _product1 = product1;
        _product2 = product2;
        _product3 = product3;
        _customer = customer;
    }

    // Getters/Setters
    public Product Product1
    {
        get { return _product1; }
        set { _product1 = value; }
    }
    public Product Product2
    {
        get { return _product2; }
        set { _product2 = value; }
    }
    public Product Product3
    {
        get { return _product3; }
        set { _product3 = value; }
    }
    public Customer Customer
    {
        get { return _customer; }
        set { _customer = value; }
    }

    // Methods
    private List<string> _products = new List<string>();
    public void AddProducts()
    {
        _products.Add($"ITEM: {Product1.ProductName} . . . . ID#: {Product1.ProductID}\n   PRICE PER EACH: {Product1.ProductPriceEa} . . . ITEM QUANTITY: {Product1.ProductQuant}");
        _products.Add($"ITEM: {Product2.ProductName} . . . . ID#: {Product2.ProductID}\n   PRICE PER EACH: {Product2.ProductPriceEa} . . . ITEM QUANTITY: {Product2.ProductQuant}");
        _products.Add($"ITEM: {Product3.ProductName} . . . . ID#: {Product3.ProductID}\n   PRICE PER EACH: {Product3.ProductPriceEa} . . . ITEM QUANTITY: {Product3.ProductQuant}");
    }

    public void PackingLabel()
    {
        Console.WriteLine("***********************************************");
        Console.WriteLine("PACKING LABEL");
        Console.WriteLine("***********************************************");
        AddProducts();
        foreach (string p in _products)
        {
            Console.WriteLine(p.ToString());
        }
        Console.WriteLine("________________________________________________");
    }

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
        decimal itemsCost3 = _product3.TotalItemsCost();

        decimal allItemsCost = itemsCost + itemsCost2 + itemsCost3;
        decimal shipping = USShipping();
        decimal totalCost = allItemsCost + shipping;

        Console.WriteLine($"Subotal for all items ordered:          ${allItemsCost}");
        Console.WriteLine($"Shipping cost:                          $ {shipping}");
        Console.WriteLine("TOTAL COST");
        Console.WriteLine($"Total cost of order:                    ${totalCost}");
        Console.WriteLine();
    }

    public void ShippingLabel()
    {
        string custName = _customer.CustomerName;
        string address = _customer.GetAddress();

        Console.WriteLine("******************");
        Console.WriteLine("SHIPPING LABEL:");
        Console.WriteLine("******************");
        Console.WriteLine(custName);
        Console.WriteLine(address);
    }
}