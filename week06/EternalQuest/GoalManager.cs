using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Formats.Asn1;
using System.IO;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;

public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score = 0;

    // Constructor
    public GoalManager(List<Goal> goals, int score)
    {
        _goals = goals;
        _score = score;
    }

    // Getters/Setters
    public List<Goal> Goals
    {
        get { return _goals; }
        set { _goals = value; }
    }

    public int Score
    {
        get { return _score; }
        set { _score = value; }
    }

    //Methods
    public void Start()
    {
        // This is "main" function: called by Program.cs and then runs the menu loop
        bool menuLoop = true;
        string menuChoice;

        do
        {
            DisplayPlayerInfo();
            Console.WriteLine();
            Console.WriteLine("Menu options:");
            Console.WriteLine("     1. Create a New Goal");
            Console.WriteLine("     2. See a List of the goals");
            Console.WriteLine("     3. Save your Goals");
            Console.WriteLine("     4. Load your saved Goals");
            Console.WriteLine("     5. Record your Goal Completion");
            Console.WriteLine("     6. Quit");
            Console.Write("What would you like to do? Select a number from the menu: ");
            menuChoice = Console.ReadLine();
            Console.WriteLine();

            // Use switch case for user choice
            switch (menuChoice)
            {
                case "1":
                    CreateGoal();
                    Console.WriteLine();
                    break;
                case "2":
                    ListGoalDetails();
                    Console.WriteLine();
                    break;
                case "3":
                    SaveGoals();
                    Console.WriteLine();
                    break;
                case "4":
                    LoadGoals();
                    Console.WriteLine();
                    break;
                case "5":
                    RecordEvent();
                    Console.WriteLine();
                    break;
                case "6":
                    menuLoop = false;
                    break;
                default:
                    Console.WriteLine("That doesn't work! You must pick a number from 1-6");
                    Console.WriteLine();
                    break;
            }

        } while (menuLoop);

    }

    public void DisplayPlayerInfo()
    {
        // Displays the player's current score
        Console.WriteLine($"You have {_score} points");
    }

    public void ListGoalNames()
    {
        //Lists the names of each of the goals
        List<Goal> goals = _goals;
        int i = 1;
        foreach (Goal goal in goals)
        {
            string name = goal.ShortName;
            Console.WriteLine($"{i}. {name}");
            i++;
        }
    }

    public void ListGoalDetails()
    {
        // Lists the details of each goal (including the checkbox of whether it's complete)
        List<Goal> goals = _goals;
        int i = 1;

        foreach (Goal goal in goals)
        {
            goal.IsComplete();
            string details = goal.GetDetailsString();
            Console.WriteLine($"{i}. {details}");
            i++;
        }
    }

    public void CreateGoal()
    {
        // Goal choice menu
        Console.WriteLine("Your Goal Options Are:");
        Console.WriteLine("     1. Simple Goal");
        Console.WriteLine("     2. Eternal Goal");
        Console.WriteLine("     3. Checklist Goal");
        Console.Write("Which type of goal would you like to create? ");
        string goalChoice = Console.ReadLine();

        // Creates the goal and adds it to the list
        switch (goalChoice)
        {
            case "1":
                Console.Write("What is the name of your goal? ");
                string name = Console.ReadLine();
                Console.Write("Give a short description of your goal: ");
                string description = Console.ReadLine();
                Console.Write("How many points do you want to earn for completing this goal? ");
                string pointsInput = Console.ReadLine();
                int points = Convert.ToInt32(pointsInput);
                SimpleGoal simpleGoal = new SimpleGoal(name, description, points, false);
                _goals.Add(simpleGoal);
                break;
            case "2":
                // For Eternal Goal
                Console.Write("What is the name of your goal? ");
                name = Console.ReadLine();
                Console.Write("Give a short description of your goal: ");
                description = Console.ReadLine();
                Console.Write("How many points do you want to earn for completing this goal? ");
                pointsInput = Console.ReadLine();
                points = Convert.ToInt32(pointsInput);
                EternalGoal eternalGoal = new EternalGoal(name, description, points);
                _goals.Add(eternalGoal);
                break;
            case "3":
                // For Checklist Goal
                Console.Write("What is the name of your goal? ");
                name = Console.ReadLine();
                Console.Write("Give a short description of your goal: ");
                description = Console.ReadLine();
                Console.Write("How many points do you want to earn for completing this goal? ");
                pointsInput = Console.ReadLine();
                points = Convert.ToInt32(pointsInput);
                Console.Write("How many times do you want to complete this goal to get bonus points? ");
                string timesInput = Console.ReadLine();
                int target = Convert.ToInt32(timesInput);
                Console.Write("How many bonus points will you get for for doing this goal that many times? ");
                string bonusInput = Console.ReadLine();
                int bonus = Convert.ToInt32(bonusInput);
                ChecklistGoal checklistGoal = new ChecklistGoal(name, description, points, 0, target, bonus);
                _goals.Add(checklistGoal);
                break;
            default:
                Console.WriteLine("Sorry! You must pick a number between 1 and 3");
                break;
        }
    }

    public void RecordEvent()
    {
        // Asks the user which goal they have done and then records the event by calling the 
        // RecordEvent method on that goal
        Console.WriteLine("The Goals Are:");

        // Display list of goal names
        ListGoalNames();

        // Choose completed goal
        Console.Write("Which goal did you finish? ");
        int completed = Convert.ToInt32(Console.ReadLine());

        // Compare choice to list index number
        List<Goal> goals = _goals;
        int points = 0;
        for (int i = 0; i < goals.Count(); i++)
        {
            Goal gNum = goals[i];
            if ((completed - 1) == i)
            {
                bool isComplete = gNum.IsComplete();
                gNum.RecordEvent();
                points = gNum.Points;
                _score = _score + points;
            }
        }

        // Encouragement statements with points info
        Console.WriteLine($"Awesome job!! You have earned {points} points!");
        Console.WriteLine($"You've now made it up to {_score} points!");
    }

    public void SaveGoals()
    {
        // Get filename
        Console.Write("What is the name of the file you'd like to save your goals to? ");
        string fileName = Console.ReadLine();

        // Saves the list of goals to a file
        List<Goal> goals = _goals;
        int points = _score;

        using (StreamWriter goalFile = new StreamWriter(fileName))
        {
            goalFile.WriteLine(points);  // Saves the current score

            foreach (Goal goal in goals)
            {
                string stringRep = goal.GetStringRepresentation();
                goalFile.WriteLine(stringRep);
            }
        }
    }

    public void LoadGoals()
    {
        // Get filename to use to retrieve information
        Console.Write("What is the name of your goal file? ");
        string fileName = Console.ReadLine();

        // Get score info from 1st line and remove it from list
        string[] goalLines = System.IO.File.ReadAllLines(fileName);
        List<string> goalInfo = new List<string>(goalLines);

        string score = goalInfo[0];
        _score = Convert.ToInt32(score);
        goalInfo.RemoveAt(0);

        // Use StreamReader to read lines and split using ':' and '~'
        _goals = new List<Goal>();

        using (StreamReader reader = new StreamReader(fileName))
        {
            string line;
            reader.ReadLine();

            while ((line = reader.ReadLine()) != null)
            {
                string[] parts = line.Split(':','~');

                if (parts.Length == 4)
                {
                    if (int.TryParse(parts[3], out int points))
                    {
                        string shortName = parts[1];
                        string description = parts[2];
                        EternalGoal eternal = new EternalGoal(shortName, description, points);
                        _goals.Add(eternal);
                    }
                }
                else if (parts.Length == 5)
                {
                    if (int.TryParse(parts[3], out int points))
                    {
                        string shortName = parts[1];
                        string description = parts[2];
                        string complete = parts[4];
                        bool isComplete = bool.Parse(complete);
                        SimpleGoal simple = new SimpleGoal(shortName, description, points, isComplete);
                        _goals.Add(simple);
                    }                       
                }
                else if (parts.Length == 7)
                {
                    if (int.TryParse(parts[3], out int points))
                    {
                        string shortName = parts[1];
                        string description = parts[2];
                        string sAmountCompleted = parts[5];
                        int amountCompleted = Convert.ToInt32(sAmountCompleted);
                        string sTarget = parts[6];
                        int target = Convert.ToInt32(sTarget);
                        string sBonus = parts[4];
                        int bonus = Convert.ToInt32(sBonus);
                        ChecklistGoal checklist = new ChecklistGoal(shortName, description, points, amountCompleted, target, bonus);
                        _goals.Add(checklist);
                    }                                            
                }
                else
                {
                    Console.WriteLine("Oops! That didn't work!");
                }
            }
        }
    }
}
