using System.Diagnostics.Contracts;
using System.Reflection.Metadata.Ecma335;

public class Listing : Activities
{
    private List<string> _ListingPrompt = new List<string>();

    public Listing(string activityName, string description) : base(activityName, description)
    {
        _ListingPrompt.Add("---Who are people that you appreciate?---");
        _ListingPrompt.Add("---What are personal strengths of yours?---");
        _ListingPrompt.Add("---Who are people that you have helped this week?---");
        _ListingPrompt.Add("---When have you felt the Holy Ghost this month?---");
        _ListingPrompt.Add("---Who are some of your personal heroes?---");
    }


    public void StartListing()
    {
        Console.WriteLine("List as many responses you can to the following prompt:");
        GetReady();
        Console.Write(">");
        // "You listed _ items!
        // final message
        // spiner
    }
}