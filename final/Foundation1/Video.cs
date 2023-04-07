using System;
using System.Collections.Generic;

class Video
{
    public string _title;
    public string _author;
    public int _lengthInSeconds;
    private List<Comment> _comments = new List<Comment>();

    public void AddComment(string commenter, string text)
    {
        _comments.Add(new Comment(commenter, text));
    }

    public int NumComments()
    {
        return _comments.Count;
    }

    public void Print()
    {
        Console.WriteLine("Title: " + _title);
        Console.WriteLine("Author: " + _author);
        Console.WriteLine("Length (seconds): " + _lengthInSeconds);
        Console.WriteLine("Number of comments: " + NumComments());
        Console.WriteLine("Comments:");
        foreach (Comment comment in _comments)
        {
            Console.WriteLine("- " + comment._commenter + " says: " + comment._text);
        }
        Console.WriteLine();
    }
}