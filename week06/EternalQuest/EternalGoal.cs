using System;

public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points) : base(name, description, points)
    {

    }

    public override void RecordEvent()
    {
        // Return the point value associated with recording the event
    }

    public override bool IsComplete()
    {
        // Return true if goal is completed
        // if (_isComplete == true)
        // {
            // return true;
        // }
        // else
        // {
           return false;
        // } 

    }

    public override string GetStringRepresentation()
    {
        return $"EternalGoal:{_shortName}~{_description}~{_points}";
    }
}