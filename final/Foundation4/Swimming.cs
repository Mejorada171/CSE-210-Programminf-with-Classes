class SwimmingActivity : Activity
{
    private int _laps;

    public SwimmingActivity(DateTime date, int length, int laps) : base(date, length)
    {
        this._laps = laps;
    }

    public override double GetDistance()
    {
        return _laps * 50.0 / 1000;
    }

    public override double GetSpeed()
    {
        return (GetDistance() / _length) * 60;
    }

    public override TimeSpan GetPace()
    {
        double paceSeconds = 60 / GetSpeed();
        return new TimeSpan(0, (int)paceSeconds, 0);
    }
    public override string GetSummary()
    {
        return string.Format("{0} {1} ({2} min) - Distance {3:0.0} miles, Speed {4:0.0} mph, Pace: {5:mm\\:ss} min per mile. Laps: {6}", 
            _date.ToString("dd MMM yyyy"), GetType().Name, _length, GetDistance(), GetSpeed(), GetPace(), _laps);
    }
}