using System;

public class Word
{
    private string _text;
    private bool _isHidden;

    public Word(string text)
    {
        _text = text;
        
        if (_isHidden == true)
        {
            Hide();
        }
        else if (_isHidden == false)
        {
            Show();
        }
        else
        {
            Console.WriteLine("Something went wrong...");
        }

    
    }

    public void Hide()
    {
        // Replace the word by underscores - one underscore for each letter in word
        // Get word length to determine # of underscores
        string verseWord = _text;
        string wordReplace = new string('_', verseWord.Length);
        _text = wordReplace;
        GetDisplayText();
    }

    public void Show()
    {
        // Use to show the word (not hide)
        GetDisplayText();
    }

    public bool IsHidden()
    {
        char textChar = '_';
        // Use to check if a word is hidden or not
        for (int i = 0; i == _text[0];)
        {
            char character = _text[0];
            if (character == textChar)
            {
                _isHidden = true;
            }
            else if (character != textChar)
            {
                _isHidden = false;
            }
            else
            {
                Console.WriteLine("Something's not right ...");
            }
        }
        return _isHidden;
    }
    
    public string GetDisplayText()
    {

        return _text;
    }

}