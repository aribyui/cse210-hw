public class Outdoors : Events
{
    private string _weatherForecast;
    
    public Outdoors(string eventType, string title, string description, string date, string time, Address address, string weatherForecast) : base(eventType, title, description, date, time, address)
    {
        _weatherForecast = weatherForecast;
    }   

    public string GetWeatherForecast()
    {
        return _weatherForecast;
    }

    public void SetWeatherForecast(string weatherForecast)
    {
        _weatherForecast = weatherForecast;
    }

    public string GetOutdoorsFullMessage()
    {
        return $"Event type:\n{_eventType}\n\nTitle:\n{_title}\n\nDescription:\n{_description}\n\nDate:\n{_date}\n\nTime:\n{_time}\n\nWeather forecast:\n{_weatherForecast}\n\nAddress:\n{_address.DisplayFullAddress()}"; 
    }
}