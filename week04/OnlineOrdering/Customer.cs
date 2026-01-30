using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;


public class Customer
{
    private string _customerName;
    private string _customerAddress;

    public Customer()
    {
        _customerName = "Unknown";
        _customerAddress = "No Where";
    }

    public Customer(string name, string address) 
    {
        _customerName = name;
        //Address address = new Address( street, city, stateProv, country);
        _customerAddress = address;
    }


    // public string custAddress()
    // {
        // Address fullAddress = new Address();
        // string cAddress = fullAddress.WholeAddress();
        // return cAddress;
    // }

    
    // public bool LivesInUSA()
    // {
    // Address inUSA = new Address();
    // bool doThey = inUSA.AddressInUSA();
    // return doThey;
    // }
}