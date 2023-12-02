public class LectureEvent : Event
{
    private string _speaker;
    private int _capacity;

    public LectureEvent(string eventTitle, string description, string date, string time, Address address, string speaker, int capacity) : base(eventTitle, description, date, time, address)
    {
        _speaker = speaker;
        _capacity = capacity;
    }

    public override string FullMessage()
    {
            // lists all the above plus speaker name and capacity
        return $"{_eventTitle}\nDescription: {_description}\nGuest Speaker {_speaker}\nWhen: {_date} at {_time}\nWhere:\n{_address.GetAddressDisplay()}\nCapasity at the event is {_capacity}";
    }

    public override string ShortMessage()
    {
        // Lists the type of event, title, and the date
        {
            return $"Type: Lecture Event\nTitle: {_eventTitle}\nDate: {_date}";
        }
    }
}