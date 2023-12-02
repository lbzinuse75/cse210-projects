public class Address
{
    private string _street;
    private string _city;
    private string _state;
    private string _ZIP;

    public Address(string street, string city, string state, string ZIP)
    {
        _street = street;
        _city = city;
        _state = state;
        _ZIP = ZIP;
    }

    public string GetAddressDisplay()
    {
        return $"{_street}\n{_city}, {_state}  {_ZIP}";
    }
}