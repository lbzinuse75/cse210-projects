using System.Reflection.Metadata;
using System.Collections.Generic;

public class Prompt
{
    // public string _prompt;
    private List<string> prompts = new List<string>();

    public Prompt()
    {
        // List<string> prompts = new List<string>();

        prompts.Add("Who was the most interesting person I interacted with today?");
        prompts.Add("What was the best part of my day?");
        prompts.Add("How did I see the hand of the Lord in my life today?");
        prompts.Add("What was the strongest emotion I felt today?");
        prompts.Add("If I had one thing I could do over today, what would it be?");
        prompts.Add("Who is your best friend?");
        prompts.Add("Who did you interact with today, and why?");
        prompts.Add("What is the last thing you did on your phone?");
        prompts.Add("What is your favorite pod cast and why?");
        prompts.Add("What is the hardest thing you have done today?");
    }

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int randomIndex = random.Next(prompts.Count);
        return prompts[randomIndex];
    }
    
}