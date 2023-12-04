public class RunActivity : Activity
{
    private int _distance;

    public RunActivity(string date, int minutes, int distance) :base(date, minutes)
    {
        _distance = distance;
    }
    
    public override double Distance()
    {
        return _distance;
    }

    public override double Speed()
    {
        return Distance() / _minutes * 60;
    }

    public override double Pace()
    {
        return 60 / Speed();
    }

    public override string GetSummary()
    {
        return $"{_date} Running ({_minutes} min): Distance {Distance()} miles, Speed {Speed()} mph, Pace {Pace()} min per mile";
    }
}