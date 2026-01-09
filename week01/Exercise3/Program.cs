using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();        
        int magicNum = randomGenerator.Next(1, 100);

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