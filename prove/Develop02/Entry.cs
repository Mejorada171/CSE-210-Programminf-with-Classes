using System;

class Entry 
{
    public string date = DateTime.Now.ToShortDateString();
    public Prompt prompt = new Prompt();
    public string user;

    public void Display()
    {
        Console.WriteLine($"{date}: {prompt.text}: {user}");
    }
}