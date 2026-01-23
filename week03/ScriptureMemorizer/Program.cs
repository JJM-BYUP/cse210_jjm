using System;
using System.Runtime.InteropServices;

class Program
/*  Other learning sources:
    "C# Development for Beginners" Series Videos by Benjamin Day on YouTube (# 5-11, 16)
    LINK: https://www.youtube.com/playlist?list=PLGxFXI4dC2si6wJeLE2Z_LSvmYnHGtAUN
    
*/
{
    static void Main(string[] args)
    {
        //Test code for Reference class
        Reference reference1 = new Reference("Ephesians", 4, 32);
        string displayRef1 = reference1.GetDisplayText();
        Console.WriteLine(displayRef1);

        Reference reference2 = new Reference("Isaiah", 12, 1, 6);
        string displayRef2 = reference2.GetDisplayText();
        Console.WriteLine(displayRef2);
    }
}