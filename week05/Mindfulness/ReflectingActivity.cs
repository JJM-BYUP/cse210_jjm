using System;
using System.Collections.Generic;

public class ReflectingActivity : Activity
{
    private List<string> _prompts = new List<string>()
    {
        "Think of a time when you did something physically challenging.",
        "Think of a time when you did something emotionally challenging.",
        "Think of a time when you did something spiritually challenging.",
        "Think of a time when you stepped out of your comfort zone to do something worthwhile.",
        "Think of a time when you helped someone in a difficult situation.",
        "Think of a time when you spoke up about something going on that was wrong.",
        "Think of a time when you were kind to someone who was not.",
        "Think of a time when you decided to try something new or learn a new skill outside of your current life experience.",
        "Think of a time when you tried to see something from someone else’s perspective.",
        "Think of a time when you made it through a difficult situation."
    };
    private List<string> _questions = new List<string>()
    {
        "What about this experience was meaningful to you?",
        "What was challenging about this experience?",
        "How did you choose to get involved or start this experience?",
        "How did you overcome any difficulties or concerns when you did this?",
        "Have you ever done anything like that before?",
        "How did this experience change you?",
        "How did you feel during or after this experience?",
        "Did you notice Heavenly Father helping you during this experience? How?",
        "How did the Spirit speak to you during this experience?",
        "What was the best part of this experience?",
        "How did you feel when it was over?",
        "What did you learn about yourself from this experience?",
        "How have you grown from this experience?",
        "What did you learn from this experience that you can use in the rest of your life?"
    };

    // Constructor
    public ReflectingActivity() : base()
    {
        _prompts = null;
        _questions = null;
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