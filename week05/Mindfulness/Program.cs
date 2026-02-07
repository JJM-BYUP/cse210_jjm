using System;
using System.Collections;
using System.ComponentModel;

/*  Mindfulness Program:
    Has three core activities:
        Breathing Activity
        Reflection Activity
        Listing Activity
    *Has one showing creativity/exceeding requirements activity:
        Sensory Activity: uses the 5-4-3-2-1 grounding method
    *Also for creativity/exceeding requirements:
        Added an instruction statement to Breathing Activity
*/

class Program
{
    static void Main(string[] args)
    {
        int choice = 0;
        do
        {
            Console.Clear();
            // Create a selection menu
            Console.WriteLine("Mindfulness Program Menu Options:");
            Console.WriteLine("     1. Breathing Activity");
            Console.WriteLine("     2. Reflection Activity");
            Console.WriteLine("     3. Listing Activity");
            Console.WriteLine("     4. Sensory Activity");
            Console.WriteLine("     5. Quit");
            Console.Write("Select a choice from the menu: ");

            // Get user input
            string input = Console.ReadLine();
            Console.Clear();

            if (int.TryParse(input, out choice))
            {
                switch (choice)
                {
                    case 1:
                        // Breathing Activity
                        BreathingActivity breathing = new BreathingActivity();
                        breathing.SetName("Breathing Activity");
                        breathing.SetDescription("This activity will help you relax and feel calm by\nhelping you focus on the rhythm of your breathing");
                        breathing.DisplayStartingMessage();
                        Console.Clear();
                        breathing.Run();
                        breathing.DisplayEndingMessage();
                        break;

                    case 2:
                        // Reflection Activity
                        ReflectingActivity reflection = new ReflectingActivity();
                        reflection.SetName("Reflection Activity");
                        reflection.SetDescription("This activity will help you think deeply about the experiences in your life\nwhen you were successful or demonstrated strength.");
                        reflection.DisplayStartingMessage();
                        Console.Clear();
                        reflection.Run();
                        reflection.DisplayEndingMessage();
                        break;

                    case 3:
                        // Listing Activity
                        ListingActivity listing = new ListingActivity();
                        listing.SetName("Listing Activity");
                        listing.SetDescription("This activity will help you recognize all of the good things in your life.\nRead the prompt, and when the timer starts, list as many things you can think of in that area.");
                        listing.DisplayStartingMessage();
                        Console.Clear();
                        listing.Run();
                        listing.DisplayEndingMessage();
                        break;

                    case 4:
                        SensoryActivity senses = new SensoryActivity();
                        senses.SetName("Sensory Activity");
                        senses.SetDescription("This activity is to help you feel grounded in the moment\nby using all of your five senses.");
                        senses.DisplayStartingMessage();
                        Console.Clear();
                        senses.Run();
                        senses.DisplayEndingMessage();
                        break;

                    case 5:
                        // Quit
                        Console.Clear();
                        break;

                    default:
                        Console.WriteLine("Default case, values need be within numbers 1-5");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Error: The input provided is not a valid number.");
            }

        } while (choice != 5);

    }
}
