public class SwimActivity : Activity
{
    private double _laps;

    public SwimActivity(string date, int minutes, int laps) :base(date, minutes)
    {
        _laps = laps;
    }
    public override double Distance()
    {
        return _laps * 50 / 1000 * 0.62;
    }

    public override double Speed()
    {
        return (Distance() / _minutes) * 60;
    }

    public override double Pace()
    {
        return _minutes / Distance();
    }

    public override string GetSummary()
    {
        return $"{_date} Swimming ({_minutes} min): Distance {Distance():F2} miles, Speed {Speed():F2} mph, Pace {Pace():F2} min per mile";
    }
}