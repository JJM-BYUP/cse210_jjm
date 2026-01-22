using System;
using System.Collections.Generic;

class Scripture
{
    private Reference _reference = new Reference("John", 3, 16);
    private List<Word> _words = new List<Word>();

    public Scripture(Reference Reference, string text)
    {

    }

    public void HideRandomWords(int numberToHide)
    {

    }

    public string GetDisplayText()
    {
        return "";
    }

    public bool IsCompletelyHidden()
    {
        return true;
    }



}
