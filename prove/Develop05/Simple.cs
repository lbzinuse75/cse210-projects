public class Simple : Goal
{
    // protected string _isComplete = "";
    public Simple(string goalType, string name, string description, int points, string complete) : base(goalType, name, description, points, complete)
    {

    }

    public override string SavingToFile()
    {
        return $"{_goalType}~{_name}~{_description}~{_points}~{_complete}";
    }

    // public string Complete()
    // {
    //     if
    // }

    // public string
    // public override void RecordEvent()
    // {

    // }

    // public override bool IsComplete()
    // {
    //     return true;
    // }
}