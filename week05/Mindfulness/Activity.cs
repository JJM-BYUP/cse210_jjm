using System;

public class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;

    // Constructor
    public Activity()
    {
        _name = "Unknown";
        _description = "Unavailable";
        _duration = 0;
    }
    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    // Getters/Setters
    public string GetName()
    {
        return _name; 
    }

    public void SetName(string name)
    {
        _name = name;
    }

    public string GetDescription()
    {
        return _description;
    }

    public void SetDescription(string description)
    {
        _description = description;
    }

    public int GetDuration()
    {
        return _duration;
    }
    
    public void SetDuration(int duration)
    {
        _duration = duration;
    }

    // Methods
    public void DisplayStartingMessage()
    {
        Console.WriteLine($"You have started the {_name}");
        Console.WriteLine();
        Console.WriteLine(_description);
        Console.WriteLine();
        Console.Write($"How long would you like this activity to run? (In seconds)  ");
        _duration = Int32.Parse(Console.ReadLine());
        Console.WriteLine();
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine();
        Console.WriteLine("Great job!");
        Console.WriteLine();
        int spinSeconds = 2;
        ShowSpinner(spinSeconds);
        Console.WriteLine($"You have finished {_duration} seconds of the {_name}.");
        Console.WriteLine();
    }

    public void ShowSpinner(int seconds)
    {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);
        List<string> spinner = new List<string>();
        spinner.Add("|");
        spinner.Add("/");
        spinner.Add("-");
        spinner.Add("\\");
        spinner.Add("|");
        spinner.Add("/");
        spinner.Add("-");
        spinner.Add("\\");

        int i = 0;

        while (DateTime.Now < endTime)
        {
            string s = spinner[i];
            Console.Write(s);
            Thread.Sleep(250);
            Console.Write("\b \b");

            i++;

            if (i >= spinner.Count)
            {
                i = 0;
            }
        }
    }

    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
    
    public void ShowDots(int seconds)
    {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);

        while (DateTime.Now < endTime)
        {
            Console.Write(". ");
            Thread.Sleep(250);
        }
    }
}