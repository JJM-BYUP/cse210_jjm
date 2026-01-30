using System;

public class Address
{
    private string _street;
    private string _city;
    private string _stateOrProv;
    private string _country;

    public Address()
    {
        _street = "";
        _city = "";
        _stateOrProv = "";
        _country = "";
    }
    
    public Address(string street, string city, string stateProv, string country)
    {
        _street = street;
        _city = city;
        _stateOrProv = stateProv;
        _country = country;
    }

    public bool AddressInUSA()
    {
        if (_country == "USA")
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
        string completeAddress = $"{_street}\n{_city}\n{_stateOrProv}\n{_country}";
        Console.WriteLine(completeAddress);
        return completeAddress;
    }

}