using System;
using System.IO;

public class Journal
{
    public string filename;

    public Journal(string journalFilename)
    {
        filename = journalFilename;
    }

    public void DisplayEntries()
    {
        if (File.Exists(filename))
        {
            Console.WriteLine("Journal Entries:");
            Console.WriteLine("");
            string[] entries = File.ReadAllLines(filename);

            foreach (string entry in entries)
            {
                Console.WriteLine(entry);
            }

            Console.WriteLine("This is the end of the Entries.");
        }

        else
        {
            Console.WriteLine("No journal entries found.");
        }
    }
}