using System;

class Program
{
    static void Main(string[] args)
    {
        string letter = "";
        Console.Write("What is your grade percentage? ");
        string userInput = Console.ReadLine();
        int gradePercentage = int.Parse(userInput);

        if (gradePercentage >= 90)
        {
            letter ="A";
        }
        else if (gradePercentage < 90 && gradePercentage >= 80)
        {
            letter = "B";
        }
        else if (gradePercentage < 80 && gradePercentage >= 70)
        {
            letter = "C";
        }
        else if (gradePercentage < 70 && gradePercentage >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        Console.WriteLine(letter);

        if (gradePercentage >= 70)
        {
            Console.WriteLine("Congratulations!! You passed the class!");
        }
        else
        {
            Console.WriteLine("Sorry you didn't pass. You will next time if you keep trying and don't give up!");
        }
    }
}