using System;

public abstract class Goal
{
    protected string _shortName;
    protected string _description;
    protected int _points;

    // Constructor
    public Goal(string name, string description, int points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }

    // Getters/Setters
    public string ShortName
    {
        get { return _shortName; }
        set { _shortName = value; }
    }

    public string Description
    {
        get {return _description;}
        set { _description = value; }
    }

    public int Points
    {
        get { return _points; }
        set { _points = value; }
    }

    // Methods
    public abstract void RecordEvent();

    public abstract bool IsComplete();

    public virtual string GetDetailsString()
    {
        string checkBox = "[ ]";
        
        return $"{checkBox} {_shortName} ({_description})";
    }

    public abstract string GetStringRepresentation();

}