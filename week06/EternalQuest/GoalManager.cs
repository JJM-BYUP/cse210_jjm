using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;

public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score;

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
        string menuChoice = "0";

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

            // Use switch case for user choice
            switch (menuChoice)
            {
                case "1":
                    CreateGoal();
                    break;
                case "2":
                    break;
                case "3":
                    break;
                case "4":
                    break;
                case "5":
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

        Console.WriteLine("You have -- points");
    }

    public static void ListGoalNames()
    {
        //Lists the names of each of the goals
        
    
    }

    public void ListGoalDetails()
    {
        // Lists the details of each goal (including the checkbox of whether it's complete)
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
        // Use switch case to handle user input// Asks the user for the information about a new goal
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
                Console.WriteLine();
                break;
        }
    }

    public void RecordEvent()
    {
        // Asks the user which goal they have dome and then records the event by calling the 
        // RecordEvent method on that goal
        Console.WriteLine("The Goals Are:");

        // Loop section to display list

        // Selection section

        // Encouragement statements with points info
        // Add point variables to these print statements
        Console.WriteLine("Awesome job!! You have earned __ points!");
        Console.WriteLine("You've now made it to __ points!");
    }

    public void SaveGoals()
    {
        // Saves the list of goals to a file
    }
    
    public void LoadGoals()
    {
        // Loads the list of goals fromm a file
    }
}
