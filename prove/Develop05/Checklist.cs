using System.ComponentModel.DataAnnotations;

public class Checklist : Goal 
{
    string _timesDone;
    private string _times;
    private int _bonus;
    // int _bonus;

    public Checklist(string goalType, string name, string description, int points, string times, int bonus, bool complete, string timesDone) : base(goalType, name, description, points, complete)
        {
            _times = times;
            _bonus = bonus;
            _timesDone = timesDone;
        }

    public override string GoalDisplay()
    {
        return $"{_goalNum}. [{Complete()}] {_name} ({_description}) -- Currently completed: {_timesDone}/{_times}";
    }

    public override string SavingToFile()
    {
        return $"{_goalNum}~{_goalType}~{_name}~{_description}~{_points}~{_bonus}~{_times}~{_timesDone}~{_complete}";
    }

    public override int RecordEvent()
    {
        int timesDone = int.Parse(_timesDone);
        timesDone++;
        _timesDone = timesDone.ToString();
        if (timesDone < int.Parse(_times))
        {
            return _points;
        }

        else if (timesDone == int.Parse(_times))
        {
            SetComplete();
            return _points + _bonus;
        }

        return 0;
    }
}