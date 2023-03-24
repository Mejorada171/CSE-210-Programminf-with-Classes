using System;

class Activity1
{
    private int _counter;

    public virtual void intro() 
    {
    }

    public int getDuration() 
    {
        Console.WriteLine("How long, in seconds, would you like for your session?");
        string duration = Console.ReadLine();
        int duration_int = Convert.ToInt32(duration);
        return duration_int;
    }

    public virtual void runActivity() 
    {
    }

    public void Timer() 
    {
        for (var i = 0; i < 10; i++) 
        {
            Turn();
            Thread.Sleep(500);
        }
        ClearCurrentConsoleLine();
    }

    public static void ClearCurrentConsoleLine()
    {
        int currentLineCursor = Console.CursorTop;
        Console.SetCursorPosition(0, Console.CursorTop);
        Console.Write(new string(' ', Console.WindowWidth)); 
        Console.SetCursorPosition(0, currentLineCursor);
    }

    public void Turn()
    {
        _counter++;
        switch (_counter % 4)
        {
            case 0:
                Console.Write("/");
                break;
            case 1:
                Console.Write("-");
                break;
            case 2:
                Console.Write("\\");
                break;
            case 3:
                Console.Write("|");
                break;
        }
        Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
    }
}