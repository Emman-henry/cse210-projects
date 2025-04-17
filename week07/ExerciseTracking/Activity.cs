using System;

public abstract class Activity
{
    private DateTime _date;
    private int _duration; // in minutes

    public Activity(DateTime date, int duration)
    {
        _date = date;
        _duration = duration;
    }

    protected abstract double GetDistance();
    protected abstract double GetSpeed();
    protected abstract double GetPace();

    public string GetSummary()
    {
        return $"{_date:dd MMM yyyy} {this.GetType().Name} ({_duration} min): " +
               $"Distance {GetDistance():0.0} miles, Speed: {GetSpeed():0.0} mph, Pace: {GetPace():0.0} min per mile";
    }

    protected int GetDuration()
    {
        return _duration;
    }
}