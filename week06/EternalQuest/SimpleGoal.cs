using System;

public class SimpleGoal : Goal
{
    private bool _isComplete;

    // Constructor
    public SimpleGoal(string name, string description, string points, bool isComplete) : base(name, description, points)
    {
        _isComplete = isComplete;
    }

    // Getters/Setters
    public bool GetIsComplete()
    {
        return false;
    }

    public void SetIsComplete(bool isComplete)
    {
        _isComplete = isComplete;
    }

    // Methods
    public override void RecordEvent()
    {

    }

    public override bool IsComplete()
    {
        return false;
    }

    public override string GetStringRepresentation()
    {
        return "";
    }
    
}