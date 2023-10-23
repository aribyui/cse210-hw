public class Receptions : Events
{
    private string _email;

    public Receptions(string evenType, string title, string description, string date, string time, Address address, string email) : base(evenType, title, description, date, time, address)
    {
        _email = email;
    }

    public string GetEmail()
    {
        return _email;
    }

    public void SetEmail(string email)
    {
        _email = email;
    }

    public string GetReceptionsFullDetailsMessage()
    {
        return $"Event type:\n{_eventType}\n\nTitle:\n{_title}\n\nDescription:\n{_description}\n\nDate:\n{_date}\n\nTime:\n{_time}\n\nAddress:\n{_address.DisplayFullAddress()}\n\nEmail:\n{_email}"; 
    }
}