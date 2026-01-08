using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string userInput = Console.ReadLine();
        int gradePercentage = int.Parse(userInput);

        if (gradePercentage >= 90)
        {
            Console.WriteLine("A");
        }
        else if (gradePercentage < 90 && gradePercentage >= 80)
        {
            Console.WriteLine("B");
        }
        else if (gradePercentage < 80 && gradePercentage >= 70)
        {
            Console.WriteLine("C");
        }
        else if (gradePercentage < 70 && gradePercentage >= 60)
        {
            Console.WriteLine("D");
        }
        else
        {
            Console.WriteLine("F");
        }
    }
}