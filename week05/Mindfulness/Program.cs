using System;
using System.Collections;

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
            Console.WriteLine("     4. Quit");
            Console.Write("Select a choice from the menu: ");

            // Get user input
            choice = int.Parse(Console.ReadLine());
            Console.Clear();

            switch (choice)
            {
                case 1:
                    // Breathing Activity
                    BreathingActivity breathing = new BreathingActivity();
                    breathing.SetName("Breathing Activity");
                    breathing.SetDescription("This activity will help you relax and feel calm\nby helping you focus on the rhythm of your breathing");
                    breathing.DisplayStartingMessage();
                    Console.Clear();
                    breathing.Run();
                    breathing.DisplayEndingMessage();
                    break;

                case 2:
                    // Reflection Activity
                    ReflectingActivity reflection = new ReflectingActivity();
                    reflection.SetName("Reflection Activity");
                    //Fix this!!
                    reflection.SetDescription("This activity will help you think deeply about experiences in your life\nwhere you were successful or demonstrated strength.");
                    reflection.DisplayStartingMessage();
                    reflection.Run();
                    reflection.DisplayEndingMessage();
                    break;

                case 3:
                    // Listing Activity
                    ListingActivity listing = new ListingActivity();
                    listing.SetName("Listing Activity");
                    listing.SetDescription("This activity will help you recognize all of the good things in your life.\nRead the prompt, and when the timer starts, list as many things you can think of in that area.");
                    listing.DisplayStartingMessage();
                    listing.Run();
                    listing.DisplayEndingMessage();
                    break;

                case 4:
                    // Quit
                    break;
            }

        } while (choice != 4);

    }
}
