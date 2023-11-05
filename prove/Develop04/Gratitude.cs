using System.Diagnostics.Contracts;
using System.Reflection.Metadata.Ecma335;

public class Gratitude : Activities
{
    private List<string> _gratitudePrompt = new List<string>();

    public Gratitude(string activityName, string description) : base(activityName, description)
    {
        _gratitudePrompt.Add("---Who are you grateful for this month?---");
        _gratitudePrompt.Add("---What are grateful for today?---");
        _gratitudePrompt.Add("---What blessing are you grateful for today?---");
        _gratitudePrompt.Add("---What modern day technology are you grateful for this year?---");
        _gratitudePrompt.Add("---What type of toilet paper are you grateful for after 2020?---");
    }


    public void StartGratitude()
    {
        Console.WriteLine("List as many responses you can to the following prompt:");
        GetGratitudePrompt();
        Console.Write("You may begin in:  "); 
        Counter();
        Console.WriteLine("");

        StartTime();
        EndTime(_startTime);
        int counter = 0;
        while(_endTime > DateTime.Now)
            {
                Console.Write(">");
                Console.ReadLine();
                counter++;
            }
        Console.WriteLine($"You listed {counter} items!");
    }

       public void GetGratitudePrompt()
    {
        Random random = new Random();
        int randomIndex = random.Next(_gratitudePrompt.Count);
        Console.WriteLine(_gratitudePrompt[randomIndex]);
    }
}