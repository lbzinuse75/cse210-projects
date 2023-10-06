using System;
using System.IO;
using System.Runtime.CompilerServices;

public class Journal
{
    public string filename;

    public Journal(string journalFilename)
    {
        filename = journalFilename;
    }

    public void DisplayEntries(List<string> loadedEntries)
    {
        {
            if (loadedEntries.Count > 0)
            {
                Console.WriteLine("Journal Entries:");
                Console.WriteLine("");
                
                foreach (string entry in loadedEntries)
                {
                    Console.WriteLine(entry);
                }
            
                Console.WriteLine("This is the end of the Entries.");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("No journal entries found.");
            }
        }
    }

    public List<string> LoadEntries()
    {
        List<string> loadedEnteries = new List<string>();
        if (File.Exists(filename))
        {
            string[] entries = File.ReadAllLines(filename);
            loadedEnteries.AddRange(entries);
        }
        return loadedEnteries;
    }

    public void SaveEntryToFile(string randomPrompt, string entry)
    {
        string filename = "journal.txt";

        using (StreamWriter outputFile = new StreamWriter(filename, true))
        {
            outputFile.WriteLine("Entry Date: " + DateTime.Now);
            outputFile.WriteLine("Prompt: " + randomPrompt);
            outputFile.WriteLine("Entry: " + entry);
            outputFile.WriteLine();
        }

        Console.WriteLine("Entry saved to journal.txt");
    }
}