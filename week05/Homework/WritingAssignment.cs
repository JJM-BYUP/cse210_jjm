using System;

public class WritingAssignment : Assignment
{
    private string _title = "";

    // Create constructor
    public WritingAssignment(string studentName, string topic, string title) : base(studentName, topic)
    {
        _title = title;
    }

    // Getters/Setters
    public string Title
    {
        get { return _title; }
        set { _title = value; }
    }

    // Method
    public string GetWritingInformation()
    {
        string studentName = StudentName;
        return $"{studentName} - {Topic}\n{_title} by {studentName}";
    }
};