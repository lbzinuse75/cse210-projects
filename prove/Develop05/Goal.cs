using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.Tracing;
using System.Security.Cryptography.X509Certificates;

public class Goal
{
    private static int _goalCount = 0;
    protected string _name;
    protected string _description;
    protected int _points;
    protected string _times;
    protected int _bonus;
    protected int _goalNum;
    protected string _complete = "";
    
   

    public Goal(string name, string description, int points)
    {
        _name = name;
        _description = description;
        _points = points;

        _goalCount++;
        _goalNum = _goalCount;
    }

    public Goal(string name, string description, int points, string times, int bonus)
    {
        _name = name;
        _description = description;
        _points = points;
        _times = times;
        _bonus = bonus;

        _goalCount++;
        _goalNum = _goalCount;
    }

    public virtual string GoalDisplay()
    {
        return $"{_goalNum}. [{_complete}] {_name} ({_description})";
    } 


    // public static void saveGoalInList(Goal goal)
    // {
    //     goalsList.Add(goal);

    //     foreach (Goal item in goalsList)
    //     {
    //         Console.WriteLine();
    //     }
    // }

    // public string DisplayScore()
    // {

    // }

    // public virtual int RecordEvent()
    // {
    //     return 10;
    // }

    public virtual bool IsComplete()
    {
        return false;
    }

}