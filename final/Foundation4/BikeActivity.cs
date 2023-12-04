public class BikeActivity : Activity
{
    private int _speed;

    public BikeActivity(string date, int minutes, int speed) :base(date, minutes)
    {
        _speed = speed;
    }

    public override double Distance()
    {
        return (_speed * _minutes) / 60;
    }

    public override double Speed()
    {
        return _speed;
    }

    public override double Pace()
    {
        return 60 / _speed;
    }

    public override string GetSummary()
    {
        return $"{_date} Biking ({_minutes} min): Distance {Distance():F2} miles, Speed {Speed():F2} mph, Pace {Pace():F2} min per mile";
    }
}