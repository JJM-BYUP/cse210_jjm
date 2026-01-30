using System;

public class Products
{
    private string _productName;
    private int _productID;
    private decimal _productPriceEa;
    private int _productQuant;

    public decimal TotalCost()
    {
        decimal total = _productPriceEa * _productQuant;
        return total;
    }
}