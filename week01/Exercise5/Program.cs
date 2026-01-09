using System;

class Program
{
    // DisplayWelcome function
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    // PromptUserName
    static string PromptUserName()
    {
        Console.Write("What is your name? ");
        string name = Console.ReadLine();
        return name;
    }

    //PromptUserNumber
    static float PromptUserNumber()
    {
        Console.Write("What is your favorite number? ");
        float number = float.Parse(Console.ReadLine());
        return number;
    }

    //SquareNumber
    static float SquareNumber(float number)
    {
        float sqrNumber = number * number;
        return sqrNumber;
    }

    // Call functions and DisplayResult (main)
    static void Main(string[] args)
    {
        string userName = PromptUserName();
        float userNum = PromptUserNumber();
        float sqrNum = SquareNumber(userNum);
        Console.WriteLine($"Hello {userName}, the square of your number is {sqrNum}");
    }
}