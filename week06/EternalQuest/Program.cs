using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        List<Goal> goals = new List<Goal>();
        GoalManager newGoal = new GoalManager(goals, 0);
        newGoal.Start();
    }
}