using System;
using System.Collections.Generic;

public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts = new List<string>()
    {
        "What tiny blessings have you noticed recently?",
        "Who has been kind to you this month?",
        "What have you done recently that has brought you joy?",
        "What are your favorite things about yourself?",
        "How have you been kind this month?",
        "What are your strengths?",
        "What goals have you accomplished so far?",
        "What songs make your heart happy?",
        "Where have you felt closest to God?",
        "What things do you do that help you feel God’s love for you?",
        "Who are the people that you love and/or appreciate?"
    };
    

    // Constructor
    public ListingActivity() : base()
    {
    }

    // Methods
    public void Run()
    {
        Console.WriteLine("Here we go!");
        ShowSpinner(2);
        Console.WriteLine();

        Console.WriteLine("List as many things as you can relating to the following prompt:");
        GetRandomPrompt();
        Console.Write("Time will start in: ");
        ShowCountDown(5);
        Console.WriteLine();

        // User input section
        List<string> userInput = GetListFromUser();
        _count = userInput.Count();
        Console.WriteLine($"You listed {_count} items!");
        Console.WriteLine();
    }

    public void GetRandomPrompt()
    {
        Random indexRandom = new Random();
        int indexNum = indexRandom.Next(0, _prompts.Count);
        string newPrompt = _prompts[indexNum];
        Console.WriteLine($"  --- {newPrompt} ---");
    }
    
    public List<string> GetListFromUser()
    {
        List<string> userInput = new List<string>();

        // Set DateTime values
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);
        
        while (DateTime.Now <= endTime)
        {
            Console.Write("> ");
            string response = Console.ReadLine();
            userInput.Add(response);
        }

        return userInput;
    }
}