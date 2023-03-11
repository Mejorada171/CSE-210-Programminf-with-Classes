using System;

class Prompt
{
    static List<string> prompts = new List<string>()
    {
        "What was the best part of your day?", 
        "Would you like to learn a topic, which one and tell me why?",
        "Tell me a good phrase for today?",
        "What about your plans for today?",
        "What do you like about your life?",
        "How was the school today?",
        "Was this a good or a bad day?",
        "Have you lived something special today?"
    };

    static Random random = new Random();

    public string text = prompts[random.Next(0, (prompts.Count() - 1))];
}