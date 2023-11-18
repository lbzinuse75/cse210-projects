using System.ComponentModel.DataAnnotations;

public class Checklist : Goal 
{
    string _timesDone;
    private string _times;
    private int _bonus;
    // int _bonus;

    public Checklist(int goalCount, string goalType, string name, string description, int points, string times, int bonus, bool complete, string timesDone) : base(goalCount, goalType, name, description, points, complete)
        {
            _times = times;
            _bonus = bonus;
            _timesDone = timesDone;
        }

    public override string GoalDisplay()
    {
        return $"{_goalCount}. [{Complete()}] {_name} ({_description}) -- Currently completed: {_timesDone}/{_times}";
    }

    public override string SavingToFile()
    {
        return $"{_goalCount}~{_goalType}~{_name}~{_description}~{_points}~{_bonus}~{_times}~{_timesDone}~{_complete}";
    }

    public override int RecordEvent()
    {
        int timesDone = int.Parse(_timesDone) + 1;
        Console.WriteLine(timesDone);
        if (timesDone < int.Parse(_times))
        {
            return _points;
        }

        else if (timesDone == int.Parse(_times))
        {
            return _points + _bonus;
        }

        return 0;
    }
}

    // public override bool IsComplete()
    // {
    //     return true;
    // }
