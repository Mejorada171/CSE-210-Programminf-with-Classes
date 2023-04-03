using System;
using System.Collections.Generic;

class Video
{
    public string Title;
    public string Author;
    public int LengthInSeconds;
    private List<Comment> comments = new List<Comment>();

    public void AddComment(string commenter, string text)
    {
        comments.Add(new Comment(commenter, text));
    }

    public int NumComments()
    {
        return comments.Count;
    }

    public void Print()
    {
        Console.WriteLine("Title: " + Title);
        Console.WriteLine("Author: " + Author);
        Console.WriteLine("Length (seconds): " + LengthInSeconds);
        Console.WriteLine("Number of comments: " + NumComments());
        Console.WriteLine("Comments:");
        foreach (Comment comment in comments)
        {
            Console.WriteLine("- " + comment.Commenter + " says: " + comment.Text);
        }
        Console.WriteLine();
    }
}