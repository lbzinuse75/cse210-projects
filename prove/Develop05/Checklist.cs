public class Checklist : Goal 
{
    string _timesDone;
    // int _bonus;

    public Checklist(string goalType, string name, string description, int points, string times, int bonus, string complete, string timesDone) : base(goalType, name, description, points, times, bonus, complete)
        {
            _timesDone = timesDone;
        }

    public override string GoalDisplay()
    {
        return $"{_goalNum}. [{_complete}] {_name} ({_description}) -- Currently completed: {_timesDone}/{_times}";
    }

    public override string SavingToFile()
    {
        return $"{_goalType}~{_name}~{_description}~{_points}~{_bonus}~{_times}~{_timesDone}~{_complete}";
    }
}
//     public override void RecordEvent()
//     {

//     }
    // public override bool IsComplete()
    // {
    //     return true;
    // }
