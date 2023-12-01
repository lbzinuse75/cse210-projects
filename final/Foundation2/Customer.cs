using System.Net.Sockets;

public class Customer
{
    private string _customerName;
    private Address _address;

    public Customer(string customerName, Address address)
    {
        _customerName = customerName;
        _address = address;
    }

    public bool CountryUSA()
    {
        return _address.GetCountry() == "USA";
    }

    public string GetCustomerInfo()
    {
        return $"{_customerName}\n{_address.GetAddress()}";
    }

    public void SetAddress(Address address)
    {
        _address = address;
    }
}