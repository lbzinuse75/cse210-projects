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

            if (parts[0] == "SimpleGoal")
            {
                // string goalType = parts[0];
                string name = parts[1];
                string description = parts[2];
                int points = int.Parse(parts[3]);
                string complete = parts[4];
            
                Simple goal = new Simple("SimpleGoal", name, description, points, complete);
                goalsList.Add(goal);
            }

            else if (parts[0] == "Eternal")
            {
                // string goalType = parts[0];
                string name = parts[1];
                string description = parts[2];
                int points = int.Parse(parts[3]);
                string complete = parts[4];
                Eternal goal = new Eternal("Eternal", name, description, points, complete);
                goalsList.Add(goal);
            }

            else if (parts[0] == "Checklist")
            {
                // string goalType = parts[0];
                string name = parts[1];
                string description = parts[2];
                int points = int.Parse(parts[3]);
                int bonus = int.Parse(parts[4]);
                string times = parts[5];
                string timesDone = parts[6];
                string complete = parts[7];
            
                Checklist goal = new Checklist("Eternal", name, description, points, times, bonus, complete, timesDone);
                goalsList.Add(goal);
            }
        }

        return goalsList;
    }
//     public void LoadGoal()
//     {

//     }
}