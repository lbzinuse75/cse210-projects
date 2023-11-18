using System.Formats.Asn1;
using System.IO;
using Microsoft.VisualBasic;

public class FileManager
{
    static string _fileName = "myFile.txt";

    public FileManager()
    {

    }

 
    public static void SaveGoalToFile(List<Goal> goals)
    {
        using (StreamWriter writer = new StreamWriter(_fileName))
        {
            foreach (Goal goal in goals)
            {
                writer.WriteLine(goal.SavingToFile());
            }
        }
    }

public static List<Goal> Load(string fileName)
    {
        Goal._goalCount = 0;
        List<Goal> goalsList = new List<Goal>();

        string[] lines = System.IO.File.ReadAllLines(fileName);

        foreach (string line in lines)
        {
            string[] parts = line.Split("~");

            if (parts[1] == "Simple")
            {
                int goalCount = int.Parse(parts[0]);
                string name = parts[2];
                string description = parts[3];
                int points = int.Parse(parts[4]);
                bool complete = bool.Parse(parts[5]);
            
                Simple goal = new Simple(goalCount, "Simple", name, description, points, complete);
                goalsList.Add(goal);
            }

            else if (parts[1] == "Eternal")
            {
                int goalCount = int.Parse(parts[0]);
                string name = parts[2];
                string description = parts[3];
                int points = int.Parse(parts[4]);
                bool complete = bool.Parse(parts[5]);
                Eternal goal = new Eternal(goalCount, "Eternal", name, description, points, complete);
                goalsList.Add(goal);
            }

            else if (parts[1] == "Checklist")
            {
                int goalCount = int.Parse(parts[0]);
                string name = parts[2];
                string description = parts[3];
                int points = int.Parse(parts[4]);
                int bonus = int.Parse(parts[5]);
                string times = parts[6];
                string timesDone = parts[7];
                bool complete = bool.Parse(parts[8]);
            
                Checklist goal = new Checklist(goalCount, "Checklist", name, description, points, times, bonus, complete, timesDone);
                goalsList.Add(goal);
            }
        }

        return goalsList;
    }
//     public void LoadGoal()
//     {

//     }
}