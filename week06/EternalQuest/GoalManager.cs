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

    //Methods
    public void Start()
    {
        // This is "main" function: called by Program.cs and then runs the menu loop
    }

    public void DisplayPlayerInfo()
    {
        // Displays the player's current score
    }

    public void ListGoalNames()
    {
        //Lists the names of each of the goals
    
    }

    public void ListGoalDetails()
    {
        // Lists the details of each goal (including the checkbox of whether it's complete)
    }

    public void CreateGoal()
    {
        // Asks the user for the information about a new goal
        // Creates the goal and adds it to the list
    }

    public void RecordEvent()
    {
        // Asks the user which goal they have dome and then records the event by calling the 
        // RecordEvent method on that goal
    }

    public void SaveGoals()
    {
        // Saves the list of goals to a file
    }
    
    public void LoadGoals()
    {
        // Loads the list of goals fromm a file
    }
}
