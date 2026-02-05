using System;
using System.Collections.Generic;

public class ReflectingActivity : Activity
{
    private List<string> _prompts;
    private List<string> _questions;

    // Constructor
    public ReflectingActivity() :base()
    {
        _prompts = null;
        _questions = null;
    }
    public ReflectingActivity(List<string> prompts, List<string> questions) 
    {
        _prompts = prompts;
        _questions = questions;
    }

    // Methods
    public void Run()
    {

    }

    public string GetRandomPrompt()
    {
        return "";
    }

    public string GetRandomQuestion()
    {
        return "";
    }

    public void DisplayRandomPrompt()
    {

    }
    
    public void DisplayQuestions()
    {
        
    }
}