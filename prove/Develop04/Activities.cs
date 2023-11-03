using System.ComponentModel;
using System.Diagnostics;

public class Activities
{
    protected string _activityName;
    protected string _description;
    protected int _duration;
    protected string _beginMessage;
    protected string _endMessage;

    protected Activities(string activityName, string description)
    {
        // _activityName = activityName;
        // _description = description;
        // _duration = duration;
        _beginMessage = $"Welcome to the {activityName} activity.";
        Console.WriteLine(_beginMessage);
        _description = description;
        Console.WriteLine(_description);
        Console.WriteLine("");
        Console.WriteLine("In seconds, how long would you like your session?");
        string userDuration = Console.ReadLine();
        _duration = int.Parse(userDuration);
        // _endMessage = "Well done!!";
    }

    protected string GetReady()
    {
        Console.WriteLine("Get ready...");
        {
            for (int i = 5; i > 0; i--)
            {
                Console.Write(i);
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }
        }
        return "Done";
    }

    // protected string Spinner()
    // {
    //     List<string> spinnerString = new List<string>();
    //     spinnerString.Add("|");
    //     spinnerString.Add("/");
    //     spinnerString.Add("-");
    //     spinnerString.Add("\\");
    //     spinnerString.Add("|");
    //     spinnerString.Add("/");
    //     spinnerString.Add("-");
    //     spinnerString.Add("\\");

    //     // foreach (string s in spinnerString)
    //     // {
    //     //     Console.Write(s);
    //     //     Thread.Sleep(1000);
    //     //     Console.Write("\b \b");
    //     // }

    //     DateTime startTime = DateTime.Now;
    //     DateTime endTime = startTime.AddSeconds(_duration);

    //     int i = 0;

    //     while (DateTime.Now < endTime)
    //     {
    //         string s = spinnerString[i];
    //         Console.Write(s);
    //         Thread.Sleep(1000);
    //         Console.Write("\b \b");

    //         i++;

    //         if (i >= spinnerString.Count)
    //         {
    //             i = 0;
    //         }

    //         Console.WriteLine("Well done!!");

    //     }
    // }
    
}  
    // protected Activities(string activityName, string description)
    // {

    // }
    // public GetStart(string activityName, string description, int duration, string beginMessage)
    // {
    //     return $"Welcome to the {activityName} activity.";
    // }

    // public string GetStart(string activityName, string description, int duration)
    // {
    //     string duration = Console.ReadLine()
    // }

    // // public GetEnd()
    // //     {
    // //         return 
    // //     }
    // private void Timer()
    // {
    //     for (int i = 5; i > 0; i--)
    //     {
    //         Console.Write(i);
    //         Thread.Sleep(1000);
    //         Console.Write("\b \b");
    //     }
    // }