using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;

class Scripture
{
    private string _reference;
    private List<string> _words = new List<string>();
   

    public Scripture(string reference, string text)
    {
        _reference = reference;
        string scriptText = text;

        // Split string text
        char separator = ' ';
        string[] verseArray = scriptText.Split(separator, StringSplitOptions.RemoveEmptyEntries); 
        _words.AddRange(verseArray);
    }

    public void HideRandomWords(int numberToHide)
    {
        // Randomize numberToHide to hide the number of words by their index numbers
        // Use a for loop to iterate through List by index?
        //foreach (var line in RandomWordsHide(_words))
        //{
        //    _text = string.Join(" ", line);
        //}

        
        //IEnumerable<List<string>> RandomWordsHide(List<string> words)
        //{
           // List<int> randomIndexes = Enumerable.Range(0, words.Count).OrderBy(x => Random.Shared.Next()).ToList();

           // int hiddenNum = numberToHide;

            //while (true)
           // {
                //yield return
                    //words
                        //.Select((word, index) =>
                            //randomIndexes
                                //.Take(hiddenNum)
                                //.Contains(index)
                                    //? Regex.Replace(word, "[a-zA-Z]", "_")
                                    //: word)
                        //.ToList();

                //if (words.Count == hiddenNum)

                   //yield break;

               // hiddenNum += Random.Shared.Next(1, words.Count - hiddenNum);

            //}

        //}
            
    }

    public string GetDisplayText()
    {
        // Add a foreach loop to iterate through List to get all the words for the scripture text 
        string text = "";
        foreach (string item in words)
        {
            
        }

        string scripture = $"{_reference} "; //{_text}
        return scripture;

    }

    public bool IsCompletelyHidden()
    {
        // Use to exit the program
        return true;
    }



}
