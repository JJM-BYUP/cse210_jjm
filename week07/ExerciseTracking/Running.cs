using System;


public class Running : Activity
{
    
    public Running(double min,double miles) : base (min, miles)
    {
        
    }


    public override void GetDistance(){}


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