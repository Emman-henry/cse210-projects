using System;

public class Running : Activity
{
    private double _distance; // in miles

    public Running(DateTime date, int duration, double distance)
        : base(date, duration)
    {
        _distance = distance;
    }

    protected override double GetDistance() => _distance;
    protected override double GetSpeed() => (_distance / GetDuration()) * 60;
    protected override double GetPace() => GetDuration() / _distance;
}
