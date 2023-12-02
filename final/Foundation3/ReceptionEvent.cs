public class ReceptionEvent : Event
{
    // private bool _RSVP;
    private string _email;

    public ReceptionEvent(string eventTitle, string description, string date, string time, Address address, string email) : base(eventTitle, description, date, time, address)
    {
        // _RSVP = false;
        _email = email;
    }

    public override string FullMessage()
    {
        // lists all the above plus email for RSVP
        return $"{_eventTitle}\nDescription: {_description}\nWhen: {_date} at {_time}\nWhere:\n{_address.GetAddressDisplay()}\nPlease RSVP to {_email}";
    }

    public override string ShortMessage()
    {
        // Lists the type of event, title, and the date
        return $"Type: Reception Event\nTitle: {_eventTitle}\nDate: {_date}";
    }
}