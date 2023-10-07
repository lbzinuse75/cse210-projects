using System;
using System.IO;

// A class that will show the date, give a random prompt, and read the journal entry
// to be used in the Journal class
public class Entry
{
    // The Entry Class Attributes
    public DateTime _date;
    public List<string> _prompts;
    public List<string> _entries;

    // The constructor
    public Entry()
    {
        _date = DateTime.Now;
        _prompts = new List<string>();
        _entries = new List<string>();
    }

    // The function that will give the writer a random prompt using the Prompt Class 
    // and read the writers entry
    public void WholeEntry()
    {
        Prompt prompt = new Prompt();
        string randomPrompt = prompt.GetRandomPrompt();
        _prompts.Add(randomPrompt);
        
        Console.WriteLine("Today's writing prompt about you: " + randomPrompt);

        string entryRandom = Console.ReadLine();
        _entries.Add(entryRandom);


        Facts facts = new Facts();
        string factPrompt = facts.GetFactPrompt();
        _prompts.Add(factPrompt);
        
        Console.WriteLine("Today's writing prompt about facts of the day: " + factPrompt);

        string entryFact = Console.ReadLine();
        _entries.Add(entryFact);
    }
}   