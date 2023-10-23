public class Lectures : Events
{
    private string _speaker;
    private int _capacity;

    public Lectures(string evenType, string title, string description, string date, string time, Address address, string speaker, int capacity) : base(evenType, title, description, date, time, address)
    {
        _speaker = speaker;
        _capacity = capacity;
    } 

    public string GetSpeaker()
    {
        return _speaker;
    }

    public void SetSpeaker(string speaker)
    {
        _speaker = speaker;
    }

    public int GetCapacity()
    {
        return _capacity;
    }

    public void SetLimitedCapacity(int capacity)
    {
        _capacity = capacity;
    }

    public string GetLectureFullDetailsMessage()
    {
        return $"Event type:\n{_eventType}\n\nTitle:\n{_title}\n\nDescription:\n{_description}\n\nSpeaker:\n{_speaker}\n\nDate:\n{_date}\n\nTime:\n{_time}\n\nCapacity:\n{_capacity}\n\nAddress:\n{_address.DisplayFullAddress()}"; 
    }
}