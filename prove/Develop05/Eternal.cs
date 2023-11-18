public class Eternal : Goal
{
        public Eternal(string goalType, string name, string description, int points, string complete) : base(goalType, name, description, points, complete)
        {
                
        }

        public override string SavingToFile()
        {
                return $"{_goalType}~{_name}~{_description}~{_points}~{_complete}";
        }   
        // public override void RecordEvent()
        // {

        // }

        // public override bool IsComplete()
        // {
        //     return true;
        // }
}