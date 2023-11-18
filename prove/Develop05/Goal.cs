using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.Tracing;
using System.Security.Cryptography.X509Certificates;

public class Goal
{
    public static int _goalCount = 0;
    protected string _name;
    protected string _description;
    protected int _points;
    protected string _times;
    protected int _bonus;
    protected int _goalNum;
    protected string _complete = "_";
    protected string _goalType;
    
   

    public Goal(string goalType, string name, string description, int points, string complete)
    {
        _name = name;
        _description = description;
        _points = points;
        _goalType = goalType;
        _complete = complete;

        _goalCount++;
        _goalNum = _goalCount;
    }

    public Goal(string goalType, string name, string description, int points, string times, int bonus, string complete)
    {
        _name = name;
        _description = description;
        _points = points;
        _goalType = goalType;
        _times = times;
        _bonus = bonus;
        _complete = complete;


        _goalCount++;
        _goalNum = _goalCount;
    }

    public virtual string GoalDisplay()
    {
        return $"{_goalNum}. [{_complete}] {_name} ({_description})";
    } 

    public virtual string SavingToFile()
    {
        return $":{_name}~{_description}~{_points}";
    }

    

    // public string DisplayScore()
    // {

    // }

    // public virtual int RecordEvent()
    // {
    //     return 10;
    // }

    // public virtual bool IsComplete()
    // {
    //     return false;
    // }

}