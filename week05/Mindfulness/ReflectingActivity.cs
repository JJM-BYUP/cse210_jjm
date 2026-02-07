using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Microsoft.Win32.SafeHandles;

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
    }

    // Methods
    public void Run()
    {
        Console.WriteLine("Here we go!");
        ShowSpinner(2);
        Console.WriteLine();

        // Random Prompt section
        DisplayRandomPrompt();
        
        Console.WriteLine("Now think about how each of the questions relates to this experience.");
        Console.Write("Questions will begin in: ");
        ShowCountDown(5);
        Console.Clear();

        // Set DateTime values
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        // Repeat Random Questions with Spinner until _duration is done
        while (DateTime.Now <= endTime)
        {
            DisplayRandomQuestions();
        }
        Console.WriteLine(); 
    }

    public string GetRandomPrompt()
    {
        Random indexRandom = new Random();
        int indexNum = indexRandom.Next(0, _prompts.Count());
        string newPrompt = _prompts[indexNum];
        return newPrompt;
    }

    public string GetRandomQuestion()
    {
        Random indexRandom = new Random();
        int indexNum = indexRandom.Next(0, _questions.Count());
        string newQuestion = _questions[indexNum];
        return newQuestion;
    }

    public void DisplayRandomPrompt()
    {
        Console.WriteLine("Consider the following prompt");
        Console.WriteLine();
 
        string newPrompt = GetRandomPrompt();
        Console.WriteLine($"  --- {newPrompt} ---");

        Console.WriteLine();
        Console.Write("When you have an experience in mind, press Enter. . .");
        Console.ReadLine();
        Console.WriteLine();
    }
    
    public void DisplayRandomQuestions()
    {
        string newQuestion = GetRandomQuestion();
        Console.Write($"> {newQuestion}  ");
        ShowSpinner(5);
        Console.WriteLine();
    }
}