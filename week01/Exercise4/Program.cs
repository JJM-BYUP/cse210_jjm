using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int userNum = -1;
        int total = 0;
        float average = 0;


        Console.WriteLine("Enter a list of numbers, type 0 when finished");

        while (userNum != 0)
        {
            Console.Write("Enter number: ");
            userNum = int.Parse(Console.ReadLine());

            if (userNum != 0)
            {
                numbers.Add(userNum);
            }
        }

        // Core requirement 1 compute sum/total of all the numbers in the list
        foreach (int number in numbers)
        {
            total += number;
        }

        // Core requirement 2 Compute the average of the numbers in the list (not counting the ending 0)
        float totalFloat = (float)total;
        float numCount = numbers.Count;
        average = totalFloat / (numCount);

        // Core requirement 3 Find the largest number in the list

        int maxNum = numbers[0];
        foreach (int number in numbers)
        {
            if (maxNum < number)
            {
                maxNum = number;
            }
        }

        // Display results
        Console.WriteLine($"The sum is {total}");
        Console.WriteLine($"The average is {average}");
        Console.WriteLine($"The largest number is {maxNum}");

    }
}