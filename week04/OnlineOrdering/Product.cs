using System;

public class Product
{
    private string _productName;
    private int _productID;
    private decimal _productPriceEa;
    private int _productQuant;

    // Constructor
    public Product(string _productName, int _productID, decimal _productPriceEa, int _productQuant)
    {
        ProductName = _productName;
        ProductID = _productID;
        ProductPriceEa = _productPriceEa;
        ProductQuant = _productQuant;
    }

    // Getters/Setters
    public string ProductName
    {
        get { return _productName; }
        set { _productName = value; }
    }

    public int ProductID
    {
        get { return _productID; }
        set { _productID = value; }
    }

    public decimal ProductPriceEa
    {
        get { return _productPriceEa; }
        set { _productPriceEa = value; }
    }

    public int ProductQuant
    {
        get { return _productQuant; }
        set { _productQuant = value; }
    }

    public decimal TotalItemsCost()
    {
        decimal total = ProductPriceEa * ProductQuant;
        return total;
    }

}