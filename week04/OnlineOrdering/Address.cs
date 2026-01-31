using System;

public class Address
{
    private string _street;
    private string _city;
    private string _stateOrProv;
    private string _country;

    // Constructors
    public Address()
    {
        Street = "";
        City = "";
        StateOrProv = "";
        Country = "";
    }

    public Address(string _street, string _city, string _stateOrProv, string _country)
    {
        Street = _street;
        City = _city;
        StateOrProv = _stateOrProv;
        Country = _country;
    }

    // Getters/Setters
    public string Street
    {
        get { return _street; }
        set { _street = value; }
    }

    public string City
    {
        get { return _city; }
        set { _city = value; }
    }

    public string StateOrProv
    {
        get { return _stateOrProv; }
        set { _stateOrProv = value; }
    }

    public string Country
    {
        get { return _country; }
        set { _country = value; }
    }

    // Methods
    public bool AddressInUSA()
    {
        if (Country == "USA")
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public string WholeAddress()
    {
        string completeAddress = $"{Street}\n{City}, {StateOrProv},{Country}";   
        return completeAddress;
    }

}