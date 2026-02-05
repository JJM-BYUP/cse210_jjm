using System;
using System.Collections.Generic;

public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts = new List<string>();

    // Constructor
    public ListingActivity(int count, List<string> prompts) 
    {
        _count = count;
        _prompts = prompts;
    }

    // Methods
    public void Run()
    {

    }

    public void GetRandomPrompt()
    {

    }
    
    public List<string> GetListFromUser()
    {
        return null;
    }
}