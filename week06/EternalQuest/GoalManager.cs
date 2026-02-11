using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;

public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score;

    // Constructor
    public GoalManager(List<Goal> goals, int score)
    {
        _goals = goals;
        _score = score;
    }

    // Getters/Setters
    public List<Goal> GetGoals()
    {
        return _goals;
    }

    public void SetGoals(List<Goal> goals)
    {
        _goals = goals;
    }

    public int GetScore()
    {
        return _score;
    }

    public void SetScore(int score)
    {
        _score = score;
    }

    public void Start()
    {

    }

    public void DisplayPlayerInfo()
    {

    }

    public void ListGoalNames()
    {

    }

    public void ListGoalDetails()
    {

    }

    public void CreateGoal()
    {

    }

    public void RecordEvent()
    {

    }

    public void SaveGoals()
    {

    }
    
    public void LoadGoals()
    {
        
    }
}
