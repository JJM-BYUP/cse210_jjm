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
        int firstCountDown = 2;
        ShowDots(firstCountDown);
        Console.WriteLine();
        Console.WriteLine();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        do
        {
            Console.Write($"Deep breath in . . . .  ");
            int breathIn = 7;
            ShowCountDown(breathIn);
            Console.WriteLine();

            Console.Write($"Slow breath out . . . .  ");
            int breathOut = 9;
            ShowCountDown(breathOut);
            Console.WriteLine();
            Console.WriteLine();
        } while (DateTime.Now <= endTime);
    }
}