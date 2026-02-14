using System;

public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points) : base(name, description, points)
    {
    }

    public override void RecordEvent()
    {
        // Return the point value associated with recording the event
        bool completed = IsComplete();
        if (completed == true)
        {
            int points = _points;
        }
    }

    public override bool IsComplete()
    {
        bool isComplete = true;
        return isComplete;
    }

    public override string GetStringRepresentation()
    {
        return $"EternalGoal:{_shortName}~{_description}~{_points}";
    }
}