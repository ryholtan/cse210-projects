using System;
using System.Collections.Generic;


public class PromptGen
{

    List<string> _prompts;


    public PromptGen()
    {
        _prompts = new List<string>()
        {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?"
        };
    }

     


    public string getPrompt()
    {
        Random dom = new Random();
        int index = dom.Next(0, _prompts.Count());
        return _prompts[index];
    }
}