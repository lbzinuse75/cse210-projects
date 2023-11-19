public class Simple : Goal
{
    public Simple(string goalType, string name, string description, int points, bool complete) : base(goalType, name, description, points, complete)
    {

    }

    public override string SavingToFile()
    {
        return $"{_goalNum}~{_goalType}~{_name}~{_description}~{_points}~{_complete}";
    }

     public override int RecordEvent()
    {
        return _points;
    }
}