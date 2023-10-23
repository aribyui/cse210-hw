public class Events
{
    protected string _eventType; 
    protected string _title;
    protected string _description;
    protected string _date;
    protected string _time;
    protected Address _address;   

    public Events(string evenType, string title, string description, string date, string time, Address address)
    {
        _eventType = evenType;
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
    }

    public string GetTitle()
    {
        return _title;
    }

    public void SetTitle(string title)
    {
        _title = title;
    }

    public string GetDescription()
    {
        return _description;
    }

    public void SetDescription(string description)
    {
        _description = description;
    }

    public string GetDate()
    {
        return _date;
    }

    public void SetDate(string date)
    {
        _date = date;
    }

    public string GetTime()
    {
        return _time;
    }

    public void SetTime(string time)
    {
        _time = time;
    }

    public Address GetAddress()
    {
        return _address;
    }

    public void SetAddress(Address addresss)
    {
        _address = addresss;
    }

    public string StandardDetailsMessage()
    {
        return $"Title:\n{_title}\n\nDescription:\n{_description}\n\nDate:\n{_date}\n\nTime:\n{_time}\n\nAddress:\n{_address.DisplayFullAddress()}";
    }

    public string FullDetailsMessage()
    {
        return $"Event type:\n{_eventType}\n\nTitle:\n{_title}\n\nDescription:\n{_description}\n\nDate:\n{_date}\n\nTime:\n{_time}\n\nAddress:\n{_address.DisplayFullAddress()}";;
    }

    public string ShortDescriptionMessage()
    {
        return $"Event type:\n{_eventType}\n\nTitle:\n{_title}\n\nDate:\n{_date}";
    }
}