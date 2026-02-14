using System;
using System.Runtime.CompilerServices;

/*
    Eternal Quest program assignment
    Author: Jennifer Merritt
*/
class Program
{
    static void Main(string[] args)
    {
        List<Goal> goals = new List<Goal>();
        GoalManager newGoal = new GoalManager(goals, 0);
        newGoal.Start();
    }
}