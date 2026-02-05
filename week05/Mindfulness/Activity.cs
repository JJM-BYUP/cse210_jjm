using System;

public class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;

    // Constructor
    public Activity()
    {
        _name = "Unknown";
        _description = "Unavailable";
        _duration = 0;
    }
    public Activity(string name, string description, int duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }

    // Getters
    public string GetName()
    {
        return _name; 
    }

    public void SetName(string name)
    {
        _name = name;
    }

    public string GetDescription()
    {
        return _description;
    }

    public void SetDescription(string description)
    {
        _description = description;
    }

    public int GetDuration()
    {
        return _duration;
    }
    
    public void SetDuration(int duration)
    {
        _duration = duration;
    }

    // Methods
    public void DisplayStartingMessage()
    {
        Console.WriteLine($"You have started the {_name}");
    }

    public void DisplayEndingMessage()
    {

    }

    public void ShowSpinner(int seconds)
    {

    }
    
    public void ShowCountDown(int seconds)
    {
        
    }
}