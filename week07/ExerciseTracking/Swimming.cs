using System;

public class Swimming : Activity
{
    private double _distance;
    private double _speed;
    private double _numOfLaps;

    // Constructor
    public Swimming(double min, double distance, double numOfLaps) : base(min)
    {
        _numOfLaps = numOfLaps;
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

    public double NumOfLaps
    {
        get { return _numOfLaps; }
        set { _numOfLaps = value; }
    }
    
    //Methods
    public override void GetDistance()
    {
        _distance = _numOfLaps * 50 / 1000 * 0.62;
    }
 
    public override void GetSpeed()
    {
        _speed = Distance / Min * 60;
    }
 
    public override void GetPace()
    {
        _pace = Min / Distance;
    }
 
    public override string GetSummary()
    {
        string activityDate = _date.ToString("dd MMM yyyy");
        _activityType = "Swimming";
        GetDistance();
        GetSpeed();
        GetPace();
        return $"{activityDate} {_activityType} ({Min} min): NUMBER OF LAPS: {_numOfLaps}, Distance: {_distance:F2} miles, Speed: {_speed:F2} mph, Pace: {_pace:F2} min per mile";
    }
}