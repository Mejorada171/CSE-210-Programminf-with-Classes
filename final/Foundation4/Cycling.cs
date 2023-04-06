class CyclingActivity : Activity
{
    private double speed;
    

    public CyclingActivity(DateTime date, int length, double speed) : base(date, length)
    {
        this.speed = speed;
    }

    public override double GetSpeed()
    {
        return speed;
    }

    public override double GetDistance()
    {
        return speed * (_length / 60.0);
    }

    public override TimeSpan GetPace()
    {
        double paceSeconds = 60.0 / speed;
        return new TimeSpan(0, 0, (int)(paceSeconds * 60));
    }

    public override string GetSummary()
    {
        return string.Format("{0} {1} ({2} min) - Distance {3:0.0} km, Speed: {4:0.0} kph, Pace: {5:mm\\:ss} min per km",
            _date.ToString("dd MMM yyyy"), GetType().Name, _length, GetDistance(), speed, GetPace());
    }
}