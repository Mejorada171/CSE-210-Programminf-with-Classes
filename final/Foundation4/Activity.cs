class Activity
{
    protected DateTime _date;
    protected int _length;
    

    public Activity(DateTime date, int length)
    {
        this._date = date;
        this._length = length;
    }

    public virtual double GetDistance()
    {
        return 0.0;
    }

    public virtual double GetSpeed()
    {
        return 0.0;
    }

    public virtual TimeSpan GetPace()
    {
        return new TimeSpan(0, 0, 0);
    }

    public virtual string GetSummary()
    {
        return string.Format("{0} {1} ({2} min)", _date.ToString("dd MMM yyyy"), GetType().Name, _length);
    }
}