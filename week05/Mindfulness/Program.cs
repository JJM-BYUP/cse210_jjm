using System;

class Program
{
    static void Main(string[] args)
    {
        BreathingActivity breathing = new BreathingActivity();
        breathing.SetName("Breathing Activity");
        breathing.SetDescription("This activity will help you relax and feel calm by helping you focus on the rhythm of your breathing");
        breathing.DisplayStartingMessage();
        breathing.Run();
        breathing.DisplayEndingMessage();
    }
}