using System;
using System.IO;
using System.Runtime.CompilerServices;

// A class that will run all the functions of the Journal once the entry is completed
public class Journal
{
    // Class Journal's attributes
    public string _filename;

    // the constructor
    public Journal(string journalFilename)
    {
        _filename = journalFilename;
    }

    // The function that will display all the journal entries after they are loaded
    // from another file where they are saved
    public void DisplayEntries(List<string> loadedEntries)
    {
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
    }

    //The function that will load all the entries from another file where they have been saved
    public List<string> LoadEntries()
    {
        List<string> loadedEnteries = new List<string>();
        if (File.Exists(_filename))
        {
            string[] entries = File.ReadAllLines(_filename);
            loadedEnteries.AddRange(entries);
        }
        return loadedEnteries;
    }

    // The function that will save the journal entries to a different file and then let the user
    // know it has been saved
    public void SaveEntryToFile(string filename, DateTime date, string prompt, string entry)
    {
        using (StreamWriter outputFile = new StreamWriter(filename, true))
        {
            outputFile.WriteLine("Entry Date: " + date);
            outputFile.WriteLine("Prompt: " + prompt);
            outputFile.WriteLine("Entry: " + entry);
            outputFile.WriteLine();
        }

        Console.WriteLine("Entry saved to " + filename);
    }
}