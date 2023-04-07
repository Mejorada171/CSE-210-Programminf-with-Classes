class RunningActivity : Activity
{
    private double _distance;

    public RunningActivity(DateTime date, int length, double distance) : base(date, length)
    {
        this._distance = distance;
    }

    public override double GetDistance()
    {
        return _distance;
    }

    public override double GetSpeed()
    {
        return _distance / (_length / 60.0);
    }

    public override TimeSpan GetPace()
    {
        double paceSeconds = _length / _distance * 60.0;
        return new TimeSpan(0, 0, (int)paceSeconds);
    }

    public override string GetSummary()
    {
        return string.Format("{0} {1} ({2} min) - Distance {3:0.0} miles, Speed {4:0.0} mph, Pace: {5:mm\\:ss} min per mile", 
            _date.ToString("dd MMM yyyy"), GetType().Name, _length, _distance, GetSpeed(), GetPace());
    }
}