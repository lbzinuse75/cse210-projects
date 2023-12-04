public abstract class Activity
{
    protected string _date;
    protected int _minutes;

    public Activity(string date, int minutes)
    {
        _date = date;
        _minutes = minutes;
    }

    public abstract double Distance();

    public abstract double Speed();

    public abstract double Pace();

    public abstract string GetSummary();

}