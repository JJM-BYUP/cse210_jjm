using System;

public class SimpleGoal : Goal
{
    protected bool _isComplete;
    //private string checkBox = "[ ]";

    // Constructor
    public SimpleGoal(string name, string description, int points, bool isComplete) : base(name, description, points)
    {
        _isComplete = isComplete;
    }

    // Getters/Setters
    public bool GetIsComplete()
    {
        return _isComplete;
    }

    public void SetIsComplete(bool isComplete)
    {
        _isComplete = isComplete;
    }

    // Methods
    public override void RecordEvent()
    {
        bool completed = IsComplete();
        if (completed == true)
        {
            int points = _points;
            checkBox = "[X]";
        }

        // Check the completed box
        // return the point value associated with recording the event
    }

    public override bool IsComplete()
    {
        // Return true if goal is completed
        _isComplete = true;
        return _isComplete;
    }

    public override string GetStringRepresentation()
    {
        return $"SimpleGoal:{_shortName}~{_description}~{_points}~{_isComplete}";
    }
    
}