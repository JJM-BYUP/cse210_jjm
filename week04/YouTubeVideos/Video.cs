using System;
using System.Dynamic;
using System.Collections.Generic;
using Microsoft.VisualBasic;
using System.Transactions;

public class Video
{
    // Track title, author, and length (in seconds)
    private string _title;
    private string _author;
    private int _length;
    private Comment _vidComment1a;
    private Comment _vidComment1b;
    private Comment _vidComment1c;

    // Constructor
    public Video(string _title, string _author, int _length, Comment vidComment1a, Comment vidComment1b, Comment vidComment1c)  
    {
        Title = _title;
        Author = _author;
        Length = _length;
        _vidComment1a = vidComment1a;
        _vidComment1b = vidComment1b;
        _vidComment1c= vidComment1c;
    }

    // Getters/Setters
    public string Title
    {
        get { return _title; }
        set { _title = value; }
    }

    public string Author
    {
        get { return _author; }
        set { _author = value; }
    }

    public int Length
    {
        get { return _length; }
        set { _length = value; }
    }

    public Comment VidComment1a
    {
        get { return _vidComment1a; }
        set
        {
            _vidComment1a = value;
        }
    }

    public Comment VidComment1b
    {
        get { return _vidComment1b; }
        set
        {
            _vidComment1b = value;
        }
    }

    public Comment VidComment1c
    {
        get { return _vidComment1c; }
        set
        {
            _vidComment1c = value;
        }
    }

    // Store a List of comments
    public List<string> _comments = new List<string>();
    public void AddVidCom()
    {
        //Adds a video's comments to a list
        string vidCom = Convert.ToString(_vidComment1a.Comments());
        string vidCom2 = Convert.ToString(_vidComment1b.Comments());
        string vidCom3 = Convert.ToString(_vidComment1c.Comments());
        _comments.Add(vidCom);
        _comments.Add(vidCom2);
        _comments.Add(vidCom3);

        Console.WriteLine("VIDEO COMMENTS:");
        foreach (string vCom in _comments)
        {
            Console.WriteLine(vCom);
            Console.WriteLine();
        }
        
    }

    public int NumOfComments()
    {
        // Returns the number of comments for a video
        int comLength = _comments.Count();
        return comLength;
    }

    public void DisplayVidInfo()
    {
        /*  For each video display:
                title, author, length, number of comments (from method), list
                all comments for that video - USE NumOfComments(); for iteration
        */

        Console.WriteLine("**************************************************");
        string vidInfo = $"VIDEO: {_title}\nPOSTED BY: {_author}\nVIDEO LENGTH (in seconds): {_length}";
        Console.WriteLine(vidInfo);
        Console.WriteLine();
        AddVidCom();
        Console.WriteLine("**************************************************");
        Console.WriteLine();
    }
}