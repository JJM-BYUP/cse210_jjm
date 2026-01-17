using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;

class Program
{

    static void Main(string[] args)
    /*  Other websites used for learning:
        https://www.youtube.com/watch?v=t2SPg6IuT3k
        https://www.youtube.com/watch?v=gaIpkQhwGXk
        https://www.youtube.com/watch?v=j6ShXTjG5fg
    */

    {
        int choice = 0;
        Entry newEntry = new Entry();
        List<string> _entries = new List<string>();
        List<string> lines = new List<string>();

        do
        {
            // Create selection menu
            Console.WriteLine("Welcome to the Journal Program!");
            Console.WriteLine("Please select from one of these options:");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Save your entry to a file");
            Console.WriteLine("3. Open journal file");
            Console.WriteLine("4. Read all entries");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");

            // Get user input and use if/else if/else to go to correct user choice
            choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    // Create AddEntry
                    // User input into variables
                    string date = DateTime.Now.ToShortDateString();

                    PromptGenerator promptRandom = new PromptGenerator();
                    string randomPrompt = promptRandom.GetRandomPrompt();

                    Console.WriteLine(randomPrompt);
                    string journalEntry = Console.ReadLine();

                    // Adding input variable values into Entry variables
                    newEntry._date = date;
                    newEntry._newPrompt = randomPrompt;
                    newEntry._entryText = journalEntry;

                    // Adding Entry variable values into List
                    _entries.Add(newEntry._date);
                    _entries.Add(newEntry._newPrompt);
                    _entries.Add(newEntry._entryText);

                    break;
                case 2:
                    // Create SaveToFile
                    string filename = "journal.txt";
                    Console.WriteLine($"Writing to {filename} now ...");

                    // Use StreamWriter to write List values to File
                    using (StreamWriter sw = File.AppendText(filename))
                        // {
                        foreach (string e in _entries)
                        {
                            sw.WriteLine(e);
                        }

                    Console.WriteLine("Done!!");
                    break;
                case 3:
                    // Create LoadFromFile
                    filename = "journal.txt";
                    lines = File.ReadAllLines(filename).ToList();

                    foreach (string line in lines)
                    {
                        //string[] items = line.Split("~");
                        string item = line;
                    }

                    break;
                case 4:
                    // Create DisplayAll
                    newEntry.Display();

                    break;

                case 5:
                    break;
            }

        } while (choice != 5);
    }

}