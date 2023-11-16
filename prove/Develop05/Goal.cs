using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.Tracing;
using System.Security.Cryptography.X509Certificates;

public abstract class Goal
{
    protected string _name;
    protected string _description;
    protected int _points;
    protected string _times;
    protected int _bonus;
    private int _goalItem = 1;
    private bool _complete = false;
    protected List<Goal> goalsList ;

    public Goal(string name, string description, int points)
    {
        _name = name;
        _description = description;
        _points = points;
    }

    public Goal(string name, string description, int points, string times, int bonus)
    {
        _name = name;
        _description = description;
        _points = points;
        _times = times;
        _bonus = bonus;
    }

    public void GoalDisplay()
    {
        Console.Write($"{_goalItem}. [{_complete}] {_name} ({_description})");
    }  


    // public string DisplayScore()
    // {

    // }

    public abstract string RecordEvent();
}