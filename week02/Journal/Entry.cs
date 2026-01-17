using System;
using System.Dynamic;
using System.Transactions;

public class Entry
{
    // Create date variable
    public string _date { get; set; }

    // Create promptText string variable
    public string _newPrompt { get; set; }

    // Create entryText string variable
    public string _entryText { get; set; }

    // Create Display()
    public void Display()
    {
        Console.WriteLine($"DATE: {_date} - PROMPT: {_newPrompt}");
        Console.WriteLine($"* {_entryText}");
        Console.WriteLine();    //Blank line
    }










}