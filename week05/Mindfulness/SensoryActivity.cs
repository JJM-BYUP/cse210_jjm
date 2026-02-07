using System;
using System.Runtime.CompilerServices;
/*  This class is to ground a person by engaging their five senses
    using the 5 4 3 2 1 technique:
        5 things you see
        4 things you touch
        3 things you hear
        2 things you smess
        1 thing you taste
*/
public class SensoryActivity : Activity
{
    private List<string> _things = new List<string>();

    // Constructor
    public SensoryActivity() : base()
    {
    }

    // Methods
    public void Run()
    {
        Console.WriteLine("Here we go!");
        ShowSpinner(2);
        Console.WriteLine();
        
        Console.WriteLine("Take a moment to look around you and consider what's making up the environment you are crrently in.");
        Console.WriteLine("Take 2 long, deep breaths and get ready to complete this activity.");
        Console.WriteLine("When you are ready, press Enter");
        Console.ReadLine();
        Console.Write("We will begin in:  ");
        ShowCountDown(5);
        Console.Clear();

        string instructForFive = "When the countdown starts, you will have 8 seconds to think of 5 things you can see:";
        string instructForFour = "When the countdown starts, you will have 7 seconds to think of 4 things you are touching:";
        string instructForThree = "When the countdown starts, you will have 6 seconds to think of 3 things you can hear:";
        string instructForTwo = "When the countdown starts, you will have 5 seconds to think of 2 things you can smell:";
        string instructForOne = "When the countdown starts, you will have 4 seconds to think of 1 things you can taste:";

        GetThings(instructForFive, 8, 5);
        Console.Clear();
        GetThings(instructForFour, 7, 4);
        Console.Clear();
        GetThings(instructForThree, 6, 3);
        Console.Clear();
        GetThings(instructForTwo, 5, 2);
        Console.Clear();
        GetThings(instructForOne, 4, 1);
        Console.Clear();


        Console.WriteLine();
        Console.WriteLine($"You became aware of 15 things in your immediate environment\nthat you saw, felt, heard, smelled, and tasted.");
        ShowSpinner(8);
        Console.WriteLine();
    }

    // MAKE A METHOD OR CLASS OF THE "GET" #S: VARIABLES FOR: instructions, seconds to run, number of items
    public void GetThings(string instructions, int seconds, int itemNum)
    {
        Console.WriteLine(instructions);
        ShowDots(5);
        Console.WriteLine();
        Console.WriteLine();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);

        int items = 0;
        while (DateTime.Now <= endTime && items < 5)
        {
            Console.Write("Counting down . . . ");
            ShowCountDown(seconds);
        }

    }
}