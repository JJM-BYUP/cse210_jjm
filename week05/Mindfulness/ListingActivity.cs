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
        _count = 0;
        _prompts = null;
    }

    // Methods
    public void Run()
    {

    }

    public void GetRandomPrompt()
    {
        Random indexNum = new Random();
        int indexRandom = indexNum.Next(0, _prompts.Count);
        string newPrompt = _prompts[indexRandom];
        Console.WriteLine(newPrompt);
    }
    
    public List<string> GetListFromUser()
    {
        return null;
    }
}