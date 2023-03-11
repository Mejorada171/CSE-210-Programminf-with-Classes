using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();

        List<string> menu = new List<string>
            {
                "Please select one of the following choices:",
                "1° Write",
                "2° Display",
                "3° Load",
                "4° Save",
                "5° Exit"
            };

        int number = 0;
        do
        {
            foreach (string option in menu)
            {
                Console.WriteLine(option);
            }   
            number = int.Parse(Console.ReadLine());
            if (number == 1)
            {
                journal.CreateJournalEntry();
            }
            if (number == 2)
            {
                journal.DisplayJournalEntries();
            }
            if (number == 3)
            {
                journal.LoadFromCSV();
            }
            if (number == 4)
            {
                journal.SaveToCSV();
            }

        } while (number != 5);
    }
}