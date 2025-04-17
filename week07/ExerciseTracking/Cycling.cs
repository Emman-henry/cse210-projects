using System;

public class Cycling : Activity
{
    private double _speed; // in mph

    public Cycling(DateTime date, int duration, double speed)
        : base(date, duration)
    {
        _speed = speed;
    }

    protected override double GetDistance() => (_speed * GetDuration()) / 60;
    protected override double GetSpeed() => _speed;
    protected override double GetPace() => 60 / _speed;
}