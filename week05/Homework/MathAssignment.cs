using System;

public class MathAssignment : Assignment
{
    private string _textbookSection;
    private string _problem;

    //Constructor
    public MathAssignment(string studentName, string topic, string textBookSection, string problem) : base(studentName, topic)
    {
        _textbookSection = textBookSection;
        _problem = problem;
    }

    // Getters/Setters
    public string TextbookSection
{
    get { return _textbookSection; }
    set { _textbookSection = value; }
}
    public string Problem
    {
        get { return _problem; }
        set { _problem = value; }
    }

    // Methods
    public string GetHomeworkList()
    {
        return $"{StudentName} - {Topic}\nSection {_textbookSection} Problems {_problem}";
    }
}