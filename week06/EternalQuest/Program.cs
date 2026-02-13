using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        SimpleGoal sGoal = new SimpleGoal("Stretch", "Stretch for 15 min every day", 15, true);
        Console.WriteLine(sGoal.GetDetailsString());

        EternalGoal eGoal = new EternalGoal("Pray", "Talk with Heavenly Father every day", 50);
        Console.WriteLine(eGoal.GetDetailsString());

        ChecklistGoal goal = new ChecklistGoal("Read Scriptures", "Read 10 minutes 3x/week", 50, 0, 3, 200);
        Console.WriteLine(goal.GetDetailsString());
        Console.WriteLine(goal.GetStringRepresentation());

        Console.WriteLine();

        List<Goal> goals = new List<Goal>();
        GoalManager newGoal = new GoalManager(goals, 0);
        newGoal.Start();

        

    }
}