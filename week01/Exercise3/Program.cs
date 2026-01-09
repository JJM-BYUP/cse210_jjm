using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is the magic number: ");
        string userMagicNum = Console.ReadLine();
        int magicNum = int.Parse(userMagicNum);

        int userGuess = -1;
        do
        {
            Console.Write("What is your guess? ");
            string userGuessNum = Console.ReadLine();
            userGuess = int.Parse(userGuessNum);

            if (magicNum > userGuess)
            {
                Console.WriteLine("Higher");
            }
            else if (magicNum < userGuess)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }
        } while (magicNum != userGuess);
    }
}