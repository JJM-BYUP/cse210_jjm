using System;
public abstract class Activity
{
    protected DateTime _date = DateTime.Now;
    private double _min;
    protected double _pace;
    protected string _activityType;

    // Constructor
    public Activity(double min)
    {
        _min = min;
    }

    // Getters/Setters
    public double Min
    {
        get { return _min; }
        set { _min = value; }
    }

    public double Pace
    {
        get { return _pace; }
        set { _pace = value; }
    }

    // Methods
    public abstract void GetDistance();
    public abstract void GetSpeed();
    public abstract void GetPace();
    public virtual string GetSummary()
    {
        string activityDate = _date.ToString("dd MMM yyyy");
        return $"{activityDate} {_activityType} ({Min} min): Distance: {GetDistance} miles, Speed: {GetSpeed} mph, Pace: {GetPace} min per mile";

    }
}
