public class Address
{
    private string _streetAddress = "";
    private string _city = "";
    private string _state = "";
    private string _country = "";
    private bool _isInUSA;

    public Address(string streetAddress, string city, string state, string country)
    {
        _streetAddress = streetAddress;
        _city = city;
        _state = state;
        _country = country;

        _isInUSA = false;
    }   

    public Address(string streetAddress, string city, string state, string country, bool isInUSA)
    {
        _streetAddress = streetAddress;
        _city = city;
        _state = state;
        _country = country;

        _isInUSA = isInUSA;
    }

    public string GetStreetAddress()
    {
        return _streetAddress;
    }

    public void SetStreetAddress(string streetAddress)
    {
        _streetAddress = streetAddress;
    }

    public string GetCity()
    {
        return _city;
    }

    public void SetCity(string city)
    {
        _city = city;
    }

    public string GetState()
    {
        return _state;
    }

    public void SetState(string state)
    {
        _state = state;
    }

    public string GetCountry()
    {
        return _country;
    }

    public void SetCountry(string country)
    {
        _country = country;
    }

    // This is a getter function - it returns the value of one of the attributes
    public bool IsInUSA()
    {
        return _isInUSA;
    }

    // // This is a setter function - it sets the value of one of the attributes
    // public bool LiveInUSA()
    // {
    //     return true;
    // }

    // // setter function to set if the address is not in USA
    // public bool DoesntLiveInUSA()
    // {
    //     return false;
    // }

    public void DisplayAddress()
    {
       Console.WriteLine($"{_streetAddress}\n{_city}, {_state}\n{_country}");
    }
}