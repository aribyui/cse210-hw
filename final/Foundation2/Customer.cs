public class Customer
{   
    private string _name = "";
    private Address _address;

    public Customer(string name, Address address)
    {
        _name = name;        
        _address = address;
    }

    public string GetName()    
    {
        return _name;
    }

    public void SetName(string name)
    {
        _name = name;
    }

    public void DisplayName()
    {
        Console.WriteLine(_name);
    }
    
    public bool LiveInUSA()
    {
        return _address.IsInUSA();
    }
}