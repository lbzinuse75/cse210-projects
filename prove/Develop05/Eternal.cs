public class Eternal : Goal
{
        public Eternal(int goalCount, string goalType, string name, string description, int points, bool complete) : base(goalCount, goalType, name, description, points, complete)
        {
                
        }

        public override string SavingToFile()
        {
                return $"{_goalCount}~{_goalType}~{_name}~{_description}~{_points}~{_complete}";
        }   

        public override int RecordEvent()
        {
                return _points;
        } 
}