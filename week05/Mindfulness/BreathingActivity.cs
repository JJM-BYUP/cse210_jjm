using System;
using System.ComponentModel;

public class BreathingActivity : Activity
{
    // Constructor
    public BreathingActivity() : base()
    {
    }
    
    // Methods
    public void Run()
    {
        Console.WriteLine("Here we go!");
        ShowSpinner(2);
        Console.WriteLine();
        Console.WriteLine("In this activity you will breath in for 7 seconds and breath out for 9 seconds.");
        Console.WriteLine("Follow the countdown in your head as you breath in and out.  Get ready...");
        ShowSpinner(5);
        Console.WriteLine();

        // Set DateTime values
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        while (DateTime.Now <= endTime)
        {
            // Breath in...
            Console.Write($"Deep breath in . . . .  ");
            ShowCountDown(7);
            Console.WriteLine();

            // Breath out...
            Console.Write($"Slow breath out . . . .  ");
            ShowCountDown(9);
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}