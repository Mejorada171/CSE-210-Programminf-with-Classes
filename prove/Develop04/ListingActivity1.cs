using System;

class ListingActivity1 : Activity1 
{

    int duration;
    public override void intro()
    {
        Console.WriteLine("Welcome to the Listing Activity.\n");
        Console.WriteLine("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
        duration = getDuration();
        runActivity(); 
    }


    public override void runActivity() 
    {
        Console.Clear();
        Console.WriteLine("Get ready...");
        Timer();
        
        string[] prompts = {
            " --- When have you felt blessed in a moment of prove? ---\n",
            " --- If you have to name some of your strengths  what would be? ---\n",
            " --- Who are people that you have helped this week? ---\n",
            " --- When have you felt the Holy Ghost this month? ---\n",
            " --- When have you have a positive impact in your community? ---\n",
            " --- Who are people that you appreciate? ---\n",
            " --- Did you remember anytime when you helped someone in need? ---\n",
            " --- What do you think has been your best action today? ---\n",
            " --- What do you think is coming for you in the future? ---\n"
        };

        Random random = new Random();
        int rand = random.Next(0, prompts.Length);
        
        Console.WriteLine("\nList as many responses as you can to the following prompt:\n");
        Console.WriteLine(prompts[rand]);
        
        Console.Write("You may begin in:  ");
        for (int k = 5; k > 0; k--) {
            Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
            Console.Write(Convert.ToString(k));
            Thread.Sleep(1000);
        }

        Console.WriteLine();
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(duration);
        
        DateTime currentTime = DateTime.Now;

        int numberItems = 0;

        while (currentTime < futureTime)
        {
            currentTime = DateTime.Now;
            Console.Write("> ");
            Console.ReadLine();
            numberItems += 1;
        }

        Console.WriteLine("\nYou listed " + numberItems + " items!");
        Console.WriteLine("\nWell done!");
        Console.WriteLine("\nYou have completed " + duration + " seconds of the Reflecting Activity. Not bad!");
        Timer();
        Console.Clear();
    }
}