using System.ComponentModel;
using System.Diagnostics;

public class Activities
{
    protected string _activityName;
    protected string _description;
    protected int _duration;
    protected string _beginMessage;
    protected string _endMessage;
    protected DateTime _startTime;
    protected DateTime _endTime;
  

    protected Activities(string activityName, string description)
    {
        _beginMessage = $"Welcome to the {activityName} activity.";
        Console.WriteLine(_beginMessage);
        _description = description;
        Console.WriteLine(_description);
        Console.WriteLine("");
        Console.WriteLine("In seconds, how long would you like your session?");
        string userDuration = Console.ReadLine();
        _duration = int.Parse(userDuration);
    }

    public void GetReady()
    {
        Console.WriteLine("Get ready...");
        {
            for (int i = 3; i > 0; i--)
            {
                Console.Write(i);
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }
        }
    }

    public void Counter()
    {
        for (int i = 3; i > 0; i--)
            {
                Console.Write(i);
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }
    }

    public void DotAnimation()
    {
        for (int i = 3; i > 0; i--)
        {
            Console.Write(".");
            Thread.Sleep(1000);
            Console.Write("");
        }
    }

    public void Spinner()
    {
        List<string> spinnerString = new List<string>();
        spinnerString.Add("|");
        spinnerString.Add("/");
        spinnerString.Add("-");
        spinnerString.Add("\\");
        spinnerString.Add("|");
        spinnerString.Add("/");
        spinnerString.Add("-");
        spinnerString.Add("\\");
        spinnerString.Add("|");

        foreach (string s in spinnerString)
        {
            Console.Write(s);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }

    public void StartTime()
        {
            _startTime = DateTime.Now;
        }

    public void EndTime(DateTime startTime)
    {
        _endTime = startTime.AddSeconds(_duration);
    }

    public void Finish(string _activityName)
    {
        DotAnimation();
        Console.WriteLine("");
        Console.WriteLine($"You have completed another {_duration} seconds of the {_activityName} activity.");
        DotAnimation();
    }    
}  