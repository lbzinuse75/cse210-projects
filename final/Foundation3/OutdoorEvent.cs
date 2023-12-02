public class OutdoorEvent : Event
{
    private string _weather;

    public OutdoorEvent(string eventTitle, string description, string date, string time, Address address, string weather) : base(eventTitle, description, date, time, address)
    {
        _weather = weather;
    }

    public override string FullMessage()
    {
        // lists all the above plus statement of weather
        return $"{_eventTitle}\nDescription: {_description}\nWhen: {_date} at {_time}\nWhere:\n{_address.GetAddressDisplay()}\nThe weather is forcast to be {_weather}";    }

    public override string ShortMessage()
    {
        // Lists the type of event, title, and the date
        return $"Type: Outdoor Event\nTitle: {_eventTitle}\nDate: {_date}";
    }
}