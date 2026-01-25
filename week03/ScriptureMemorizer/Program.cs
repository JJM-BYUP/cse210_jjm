using System;
using System.Runtime.InteropServices;

class Program
/*  Other learning sources:
    1. "C# Development for Beginners" Series Videos by Benjamin Day on YouTube (# 5-11, 16)
    LINK: https://www.youtube.com/playlist?list=PLGxFXI4dC2si6wJeLE2Z_LSvmYnHGtAUN
    2. https://www.geeksforgeeks.org/c-sharp/string-split-method-in-c-sharp/
    3. https://learn.microsoft.com/en-us/dotnet/csharp/how-to/parse-strings-using-split
    4. https://www.youtube.com/watch?v=-ETZ0nOCU14
    
*/
{
    static void Main(string[] args)
    {
        string userInput = "a";

       
       
            
            

            string ref1 = "1 Nephi";
            string verse1 = "And my father dwelt in a tent.";

            Reference reference1 = new Reference(ref1, 2, 15);
            string displayRef1 = reference1.GetDisplayText();
        //Test display code for Reference class reference1
        //Console.WriteLine(displayRef1);

        //Test display code for Reference Class reference2
        //Reference reference2 = new Reference("Isaiah", 12, 1,6);
        //string displayRef2 = reference2.GetDisplayText();
        //Console.WriteLine(displayRef2);

        Scripture scripture1 = new Scripture(displayRef1, verse1);
        do
        {
            // Clear the console
            Console.Clear();
            
            if (userInput == "")
            {
                // Print Scripture reference and text with missing words    
                scripture1.HideRandomWords(2);
            }
            
            string displayScript = scripture1.GetDisplayText();
            Console.WriteLine(displayScript);
            Console.WriteLine();

            // User input
            Console.WriteLine("Press ENTER to continue or type 'quit' to stop");
            userInput = Console.ReadLine();

        } while (!userInput.Equals("quit", StringComparison.OrdinalIgnoreCase));
        
    }
}