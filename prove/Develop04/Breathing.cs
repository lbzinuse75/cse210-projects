using System.Diagnostics;
using System.Runtime.CompilerServices;

public class Breathing : Activities
{
    public Breathing(string activityName, string description) : base(activityName, description)
    {

    }

    public void GetReadyB()
    {
        GetReady();
    }

    public void SpinnerB()
    {
        Spinner();
    }

    public void StartBreathing()
    {
        Console.WriteLine("Breath In");
        for (int i = 4; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
        Console.WriteLine("Hold Breath");
        for (int i = 7; i> 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
        Console.WriteLine("Breath Out");
        for (int i = 8; i> 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
}