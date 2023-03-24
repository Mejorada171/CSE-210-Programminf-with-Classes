class ReflectingActivity1 : Activity1 
{    
    int duration;
    public override void intro()
    {
        Console.WriteLine("Welcome to the Mindfulness Program.\n");
        Console.WriteLine("This activity will help you reflect on times in your life when you have shown strength and resilience.");
        Console.WriteLine("This will help you recognize and ponder about the power you have and how you can use it, in addition you would notice the divine help from the Heavenly Father in you life.\n");
        duration = getDuration();
        runActivity(); 
    }

    public override void runActivity() 
    {
        Console.Clear();
        Console.WriteLine("Get ready..."); 
        Timer();
        
        string[] prompts = 
        {
            " --- Think of a time when you helped someone in need. ---\n",
            " --- Think of a time when you felt the Holy Ghost. ---\n",
            " --- Think of a time when you were willing to serve in the church. ---\n",
            " --- Think of a time when you did something truly good. ---\n",
            " --- Think of a time when you caused a good impact in someone else?. ---\n",
            " --- Think of a time when you felt overwhelmed but you were able to succeed. ---\n"
        };
        string[] questions = 
        {
            "> Why was this experience meaningful to you?",
            "> What did you learn about yourself through this experience?",
            "> What made this time different than other times when you were not as successful?",
            "> Have you ever done anything like this before?",
            "> How did you get started?",
            "> How did you feel when it was complete?",
            "> What is your favorite thing about this experience?",
            "> What could you learn from this experience that applies to other situations?",
            "> How can you keep this experience in mind in the future?"
        };

        Random random = new Random();
        int rand = random.Next(0, prompts.Length);
        
        Console.WriteLine("\nConsider the following prompt:\n");
        Console.WriteLine(prompts[rand]);
        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();

        Console.WriteLine("\nNow ponder on each of the following questions as they related to this experience.\n");

        Console.Write("You may begin in:  ");
        for (int k = 5; k > 0; k--) {
            Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
            Console.Write(Convert.ToString(k));
            Thread.Sleep(1000);
        }

        Console.Clear();

        int temp_duration = duration;

        foreach (string question in questions) 
        {

            if (temp_duration <= 0) {
                break;
            }

            Console.WriteLine(question);
            Timer();
            temp_duration = temp_duration - 5;
        }

        Console.WriteLine("\nWell done!");
        Console.WriteLine("\nYou have completed " + duration + " seconds of the Reflecting Activity.");
        Timer();
        Console.Clear();
    }
}