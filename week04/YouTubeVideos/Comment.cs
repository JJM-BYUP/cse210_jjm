using System;

public class Comment
{
    // Track the commenter name and comment text
    private string _commenterName;
    private string _commentText;

    // Constructor
    public Comment(string _commenterName, string _commentText)
    {
        CommenterName = _commenterName;
        CommentText = _commentText;
    }

    // Getters/Setters
    public string CommenterName
    {
        get { return _commenterName; }
        set
        {
            _commenterName = value;
        }
    }

    public string CommentText
    {
        get { return _commentText; }
        set
        {
            _commentText = value;
        }
    }

    // Method
    public string Comments()
    {
        string vidComments = $"{_commenterName}\n{_commentText}";
        return vidComments;
    }
}