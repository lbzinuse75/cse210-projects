using System.Reflection.Metadata;
using System.Collections.Generic;

// Create a class that will hold a list of prompts and then Randomly select
// a prompt for the user and display it to the console
public class Prompt
{
    // Class Prompt's attributes which is a list
    private List<string> prompts = new List<string>();

    // the constructor holding the information of the list
    public Prompt()
    {
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

    // method that calls the Random method to randomly go through the list and pick an indexed
    // prompt to display to the writer
    public string GetRandomPrompt()
    {
        Random random = new Random();
        int randomIndex = random.Next(prompts.Count);
        return prompts[randomIndex];
    }
    
}