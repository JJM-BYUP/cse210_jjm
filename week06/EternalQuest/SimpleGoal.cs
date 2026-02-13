using System;

public class SimpleGoal : Goal
{
    private bool _isCompleted;

    // Constructor
    public SimpleGoal(string name, string description, int points, bool isCompleted) : base(name, description, points)
    {
        _isCompleted = isCompleted;
    }

    // Getters/Setters
    public bool IsCompleted
    {
        get { return false; }
        set { _isCompleted = value; }
    }

    // Methods
    public override void RecordEvent()
    {
        // Check the completed box
        // return the point value associated with recording the event
    }

    public override bool IsComplete()
    {
        // Return true if goal is completed
        if (_isCompleted == true)
        {
            return true;
        }
        else
        {
            return false;
        } 
    }

    public override string GetStringRepresentation()
    {
        return $"SimpleGoal:{_shortName}~{_description}~{_points}~{_isCompleted}";
    }
    
}