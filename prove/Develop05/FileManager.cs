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
                writer.WriteLine(goal.GetStringRepresentation());
            }
        }
    }

public static List<Goal> ParseGoalFromString(string fileName)
    {
        Goal._goalCount = 0;
        List<Goal> goalsList = new List<Goal>();

        string[] lines = System.IO.File.ReadAllLines(fileName);

        foreach (string line in lines)
        {
            string[] parts = line.Split("~");

            // if (parts[0] == "SimpleGoal")
            {
                string name = parts[0];
                string description = parts[1];
                int points = int.Parse(parts[2]);
                // bool iscomplete = bool.Parse(parts[4]);
            
                Simple goal = new Simple(name, description, points);
                goalsList.Add(goal);
            }
        }

        return goalsList;
    }
//     public void LoadGoal()
//     {

//     }
}