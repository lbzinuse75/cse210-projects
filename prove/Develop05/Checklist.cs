public class Checklist : Goal 
{
    int _total;
    // int _targetTotal;
    // int _bonus;

    public Checklist(string name, string description, int points, string times, int bonus) : base(name, description, points, times, bonus)
        {

        }

    public override string GoalDisplay()
    {
        return $"{_goalNum}. [{_complete}] {_name} ({_description}) -- Currently completed: {_total}/{_times}";
    }
}
//     public override void RecordEvent()
//     {

//     }
    // public override bool IsComplete()
    // {
    //     return true;
    // }
