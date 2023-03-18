using System;

class Program
{

    static void Main(string[] args)
    {
        Reference scriptureReference = new Reference("Proverbs","3","5-6");
        Scripture scripture = new Scripture(scriptureReference, "Trust in the lord with all thine heart; and learn not unto thine own understanding; in all thy ways acknowledge him, and he shall direct thy paths.");

        string userInput = "";

        while (userInput != "quit" && scripture.HasWordsLeft())
        {
            Console.Clear();
            Console.WriteLine(string.Format("{0}", scriptureReference.toString()));
            scripture.DisplayScriptureText();
            Console.WriteLine("\nPress enter to continue or type quit to finish");
            userInput = Console.ReadLine();
            scripture.HideWords();

        }
        Console.Clear();
        Console.WriteLine(string.Format("{0}", scriptureReference.toString()));
        scripture.DisplayScriptureText();
        Console.WriteLine("\nNow you memorized the scripture!");
        userInput = Console.ReadLine();
    }
}
