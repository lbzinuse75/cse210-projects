using System.Net.Sockets;

public class Event
{
    protected string _eventTitle;
    protected string _description;
    protected string _date;
    protected string _time;
    protected Address _address;

    public Event()
    {

    }

    public Event(string eventTitle, string description, string date, string time, Address address)
    {
        _eventTitle = eventTitle;
        _description = description;
        _date = date;
        _time = time; 
        _address = address;
    }

    public virtual string StandardMessage()
    {
        // lists the title, description, date, time, and address
        return $"{_eventTitle}\nDescription: {_description}\nWhen: {_date} at {_time}\nWhere:\n{_address.GetAddressDisplay()}";
    }

    public virtual string FullMessage()
    {
        // lists all the above plus type of event and information specific to that event type
        return "";
    }

    public virtual string ShortMessage()
    {
        // Lists the type of event, title, and the date
        return "";
    }
}