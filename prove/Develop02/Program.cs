using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Security.Authentication.ExtendedProtection;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Journal myJournal = new Journal("journal.txt");

        Console.WriteLine("Welcome Back to Your Journal!");
        bool continueProgram = true;

        while (continueProgram)
        {
            Console.WriteLine("Please select one of the following choices.");
            Console.WriteLine("1. Write and Entry");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.WriteLine("What would you like to do?");
            int answer = int.Parse(Console.ReadLine());

            if (answer == 1)
            {
                // use entry class
                Prompt prompt = new Prompt();
                string randomPrompt = prompt.GetRandomPrompt();
                Console.WriteLine("Today's writing prompt: " + randomPrompt);
                string entry = Console.ReadLine();
                SaveEntryToFile(randomPrompt, entry);
            }

            else if (answer == 2)
            {
                // call the display
                myJournal.DisplayEntries();
            }

            else if (answer == 3)
            {
                // call the load
            }

            else if (answer == 4)
            {
                // save file
            }

            else if (answer == 5)
            {
                // quit
                continueProgram = false;
                // break;
            }
        }
    }

    // public static void SaveEntryToFile(List<string> entries, string filename)
    public static void SaveEntryToFile(string randomPrompt, string entry)
    {
        string filename = "journal.txt";

        using (StreamWriter outputFile = new StreamWriter(filename, true))
        {
            outputFile.WriteLine("Entry Date: " + DateTime.Now);
            outputFile.WriteLine("Prompt: " + randomPrompt);
            outputFile.WriteLine(entry);
            outputFile.WriteLine();
        }

        Console.WriteLine("Entry saved to journal.txt");
    }
}

    //         foreach (string entry in entries)
    //         {
    //             outputFile.WriteLine(entry);
    //         }
    //     }
    // }

    // public static List<string> ReadFromFile(string filename)
    // {
    //     Console.WriteLine("Reading list from file...");
    //     List<string> entries = new List<string>();

    //     if (File.Exists(filename))
    //     {
    //         entries.AddRange(File.ReadAllLines(filename));
    //     }
    // //     string filename = "journal.txt";

    //     return entries;
    // }
