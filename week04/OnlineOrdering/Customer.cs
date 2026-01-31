using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;


public class Customer
{
    private string _customerName;
    private Address _address;

    // Constructor
    public Customer(string _customerName, Address address)
    {
        CustomerName = _customerName;
        _address = address;
    }

    // Getters/Setters
    public string CustomerName
    {
        get { return _customerName; }
        set { _customerName = value; }
    }

    // Methods
    public string GetAddress()
    {
        return _address.WholeAddress();
    }

    public bool GetInUSA()
    {
        return _address.AddressInUSA();
    }
}