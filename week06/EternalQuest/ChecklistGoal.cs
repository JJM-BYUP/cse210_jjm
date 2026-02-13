using System;

public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    // Constructor
    public ChecklistGoal(string name, string description, int points, int amountCompleted, int target, int bonus) : base(name, description, points)
    {
        _amountCompleted = amountCompleted;
        _target = target;
        _bonus = bonus;
    }

    // Getters/Setters
    public int GetAmountCompleted()
    {
        return _amountCompleted;
    }

    public void SetAmountCompleted(int amountCompleted)
    {
        _amountCompleted = amountCompleted;
    }

    public int GetTarget()
    {
        return 0;
    }

    public void SetTarget(int target)
    {
        _target = target;
    }

    public int GetBonus()
    {
        return 0;
    }

    public void SetBonus(int bonus)
    {
        _bonus = bonus;
    }

    // Methods
    public override void RecordEvent()
    {
        // Add to number of times this goal has been completed
        
        // Mark goal complete when it hits the target number


        // Add points for each time goal has been completed

        // Add bonus points for when the target number has been reached

    }

    public override bool IsComplete()
    {
        // MIGHT NEED TO EVALUATE THE IF ELSE STRUCTURE
        // Return true if goal is completed

        // Return true if target has been reached
        if (_amountCompleted == _target)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public override string GetDetailsString()
    {
        string checkBox = "[ ]";
        return $"{checkBox} {_shortName} ({_description}) -- Currently completed: {_amountCompleted}/{_target}";
    }

    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal:{_shortName}~{_description}~{_points}~{_bonus}~{_target}~{_amountCompleted}";
    }

}
