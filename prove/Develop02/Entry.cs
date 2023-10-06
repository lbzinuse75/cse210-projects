using System;
using System.IO;

// A class that will show the date, give a random prompt, and read the journal entry
// to be used in the Journal class
public class Entry
{
    // The Entry Class Attributes
    public DateTime _date;
    public string _prompt;
    public string _entry;

    // The constructor
    public Entry()
    {
        _date = DateTime.Now;
        _prompt = string.Empty;
        _entry = string.Empty;
    }

    // The function that will give the writer a random prompt using the Prompt Class 
    // and read the writers entry
    public void WholeEntry()
    {
        Prompt prompt = new Prompt();
        _prompt = prompt.GetRandomPrompt();
        Console.WriteLine("Today's writing prompt: " + _prompt);
        _entry = Console.ReadLine();
    }
}   