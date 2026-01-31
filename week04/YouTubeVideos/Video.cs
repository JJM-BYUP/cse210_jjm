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
    public Video(string _title, string _author, int _length, Comment vidComment1a, Comment vidComment1b, Comment vidComment1c)  //
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

    // public Comment VidComment1b
    // {
        // get { return _vidComment1b; }
        // set
        // {
            // _vidComment1b = value;
        // }
    // }

    // public Comment VidComment1c
    // {
        // get { return _vidComment1c; }
        // set
        // {
            // _vidComment1c = value;
        // }
    // }

    // Store a List of comments
    public List<string> _comments = new List<string>();
    public void AddVidCom()
    {
        string vidCom = Convert.ToString(_vidComment1a.Comments());
        _comments.Add(vidCom);
        foreach (string vc in _comments)
        {
            Console.WriteLine(vc);
        }
    }

    public int NumOfComments()
    {
        // This method is to return the number of comments
        int comLength = _comments.Count();
        return comLength;
    }

    public string Display()
    {
        int commentLen = NumOfComments();
        string vidInfo = $"{_title}\n{_author}\n{_length}";
        AddVidCom();
        return vidInfo;
    }
}