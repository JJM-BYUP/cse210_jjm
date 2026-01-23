using System;
using System.Data;

public class Reference
{
    private string _book;
    private int _chapter;
    private int _verse;
    private int _endVerse;

    public Reference(string book, int chapter, int startVerse, int endVerse = 0)
    {
        //Ephesians 4:32 or Isaian 12:1-6
        _book = book;
        _chapter = chapter;
        _verse = startVerse;
        _endVerse = endVerse;
    }
    
    public string GetDisplayText()
    {
        string singleVerse = $"{_book} {_chapter}:{_verse}";
        string multiVerse = $"{_book} {_chapter}:{_verse}-{_endVerse}";

        if (_endVerse < 1)
        {
            return singleVerse;
        }
        else
        {
            return multiVerse;
        }
    }

}