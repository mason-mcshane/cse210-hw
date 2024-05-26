using System;
using System.Collections.Generic;

public class Prompts
{
    public List<string> _promptList = new List<string>()
    {
        "What was the best part of the day?",
        "How did you feel when you woke up this morning?",
        "What is something helpful I did today?",
        "What is something I can do better after today?",
        "What was the worst part of my day?",
        "What was something I learned today?",
        "WHat is something I hope to learn tommorrow?"
    };

    public Random rand = new Random();
    public string GenerateRandomPrompt()
    {
        int index = rand.Next(_promptList.Count);
        return _promptList[index];
    }

}