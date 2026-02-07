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
        Console.WriteLine();
        ShowDots(2);
        Console.WriteLine();
        Console.WriteLine();

        // Set DateTime values
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        do
        {
            // Breath in...
            Console.Write($"Deep breath in . . . .  ");
            ShowCountDown(7);
            Console.WriteLine();

            // Breath out...
            Console.Write($"Slow breath out . . . .  ");
            ShowCountDown(9);
            Console.WriteLine();
            Console.WriteLine();
        } while (DateTime.Now <= endTime);
    }
}