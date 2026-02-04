using System;

public class Assignment
{
    protected string _studentName;
    protected string _topic;

    // Constructor
    public Assignment(string studentName, string topic)
    {
        _studentName = studentName;
        _topic = topic;
    }

    // Getters/Setters
    public string StudentName
    {
        get { return _studentName; }
        set { _studentName = value; }
    }

    public string Topic
    {
        get { return _topic; }
        set { _topic = value; }
    }

    public string GetSummary()
    {
        string summary = $"{_studentName} - {_topic}";
        return summary; 
    }
}