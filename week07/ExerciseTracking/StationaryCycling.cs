using System;

public class StationaryCycling : Activity
{
    public StationaryCycling(double min, double distance) : base(min, distance)
    {
    }

    public override void GetDistance() { }

    public override void GetSpeed()
    {
        _speed = Distance / Min * 60;
    }

    public override void GetPace()
    {
        _pace = 60 / _speed;
    }

    public override string GetSummary()
    {
        string activityDate = _date.ToString("dd MMM yyyy");
        _activityType = "Stationary Cycling";
        GetDistance();
        GetSpeed();
        GetPace();
        return $"{activityDate} {_activityType} ({Min} min): SPEED: {_speed:F2} mph, Distance: {_distance:F2} miles, Pace: {_pace:F2} min per mile";
    }
}