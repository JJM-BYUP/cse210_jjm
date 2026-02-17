using System;
public abstract class Activity
{

    protected DateTime _date = DateTime.Now;
    protected double _distance;
    private double _min;
    protected double _speed;
    protected double _pace;
    protected string _activityType;


    public Activity(double min, double distance)
    {
        _min = min;
        _distance = distance;
    }


    public double Min
    {
        get { return _min; }
        set { _min = value; }
    }

    public double Distance
    {
        get { return _distance; }
        set { _distance = value; }
    }

    public abstract void GetDistance();
    public abstract void GetSpeed();
    public abstract void GetPace();
    public virtual string GetSummary()
    {
        string activityDate = _date.ToString("dd MMM yyyy");
        GetDistance();
        GetSpeed();
        GetPace();
        return $"{activityDate} {_activityType} ({Min} min): Distance: {_distance:F2} miles, Speed: {_speed:F2} mph, Pace: {_pace:F2} min per mile";

    }
}
