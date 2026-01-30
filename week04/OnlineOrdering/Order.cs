using System;

public class Order
{
    private List<string> _products = new List<string>();
    private string _customer;
    private decimal _orderCost;
    private decimal _shippingUSA = 5.00m;
    private decimal _shippingNotUSA = 35.00m;

    public string PackingLabel()
    {
        
        return "";
    }

    public string ShippingLabel()
    {
        return "";
    }
}