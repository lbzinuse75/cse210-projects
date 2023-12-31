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
    protected int _goalNum;
    protected bool _complete;
    protected string _goalType;

    public Goal(string goalType, string name, string description, int points, bool complete)
    {
        _name = name;
        _description = description;
        _points = points;
        _goalType = goalType;
        _complete = complete;

        _goalCount++;
        _goalNum = _goalCount;
    }

    public virtual string GoalDisplay()
    {
        return $"{_goalNum}. [{Complete()}] {_name} ({_description})";
    } 

    public virtual string SavingToFile()
    {
        return $"{_goalNum}~{_goalType}~{_name}~{_description}~{_points}";
    }

    public string Complete()
    {
        if (_complete)
            return "X";
        else
            return " ";
    }

    public void SetComplete()
    {
        _complete = true;
    }

    public string GetGoalType()
    {
        return _goalType;
    }

    public virtual int RecordEvent()
    {
        return _points;
    }    
}