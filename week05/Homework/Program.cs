using System;
using System.Linq.Expressions;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment = new Assignment("Joe Shmo", "Multiplication");
        Console.WriteLine(assignment.GetSummary());
        Console.WriteLine();

        MathAssignment math = new MathAssignment("Peter Pumpkineater", "Equations", "Word Problems", "1-12");
        Console.WriteLine(math.GetHomeworkList());
        Console.WriteLine();

        WritingAssignment writing = new WritingAssignment("Mary Contrary", "English", "The Historical Relevance of Nursery Rhymes During the Middle Ages");
        string writingInfo = writing.GetWritingInformation();
        Console.WriteLine($"{writingInfo}");
    }
}