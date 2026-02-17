using System;
/*
    CSE210 Week 7 -Exercise Tracking Assignment
    Purpose: Track workout details for three activities: 
        Running, Stationary Cycling, Swimming
    Author: Jennifer Merritt
*/
class Program
{
    static void Main(string[] args)
    {
        Running run1 = new Running(30, 3.0);

        StationaryCycling cycle1 = new StationaryCycling(20, 13.4);

        Swimming swimm1 = new Swimming(60, 0, 55);

        List<Activity> activities = new List<Activity>();
        activities.Add(run1);
        activities.Add(cycle1);
        activities.Add(swimm1);

        foreach (Activity act in activities)
        {
            Console.WriteLine(act.GetSummary());
        }
    }
}