using System;


public class Running : Activity
{
    private double _distance;
    private double _speed;

    // Constructor
    public Running(double min, double distance) : base(min)
    {
        _distance = distance;
    }

    // Getters/Setters
    public double Distance
    {
        get { return _distance; }
        set { _distance = value; }
    }

    public double Speed
    {
        get { return _speed; }
        set { _speed = value; }
    }

    // Methods
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
        _activityType = "Running";
        GetDistance();
        GetSpeed();
        GetPace();
        return $"{activityDate} {_activityType} ({Min} min): DISTANCE: {_distance:F2} miles, Speed: {_speed:F2} mph, Pace: {_pace:F2} min per mile";
    }


}