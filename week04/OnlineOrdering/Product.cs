using System;

public class Product
{
    private string _productName;
    private int _productID;
    private decimal _productPriceEa;
    private int _productQuant;

    public Product()
    {
        _productName = "Stuff";
        _productID = 0;
        _productPriceEa = 0m;
        _productQuant = 0;
    }

    public Product(string pName, int pID, decimal pPriceEa, int pQuant)
    {
        _productName = pName;
        _productID = pID;
        _productPriceEa = pPriceEa;
        _productQuant = pQuant;
    }

    public decimal TotalCost()
    {
        decimal total = _productPriceEa * _productQuant;
        return total;
    }
}