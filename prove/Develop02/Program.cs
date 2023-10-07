using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Security.Authentication.ExtendedProtection;
using System.Security.Cryptography.X509Certificates;

// Create a Journal Program that would hopefully help someone write
// in their journal more.  Using 2 or more classes in this Journal Program.
class Program
{
    static void Main(string[] args)
    {
        // Call the Journal Class to be referenced.
        Journal myJournal = new Journal("journal.txt");
        // Call the Entry Class to be referenced.
        Entry entry = new Entry();
        
        // start the loadedEntries list as blank
        List<string>loadedEntries = new List<string>();

        // Welcome the writer and make a loop of the menu to chose what action 
        // they want to take.
        Console.WriteLine("Welcome Back to Your Journal!");
        bool continueProgram = true;

        // Program will loop as long as continueProgram is true as set above.
        while (continueProgram)
        {
            Console.WriteLine("Please select one of the following choices.");
            Console.WriteLine("1. Write an Entry");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.WriteLine("What would you like to do?");
            int answer = int.Parse(Console.ReadLine());

            if (answer == 1)
            {
                // call the entry class to write and entry
                entry.WholeEntry();
            }

            else if (answer == 2)
            {
                // display the Journal entries from the Journal class
                // with the DisplayEntries method
                myJournal.DisplayEntries(loadedEntries);
            }

            else if (answer == 3)
            {
                // load the Journal enteries from the Journal class
                // with the LoadEntries method
                loadedEntries = myJournal.LoadEntries();
                Console.WriteLine("Entries Loaded");
                Console.WriteLine("");
            }

            else if (answer == 4)

                    // save the Journal entry from the Journal class
                    // with the SaveEntrytoFile method
                    myJournal.SaveEntriesToFile("journal.txt", entry._date, entry._prompts, entry._entries);

            else if (answer == 5)
            {
                // quit the program
                continueProgram = false;
            }
        }
    }
}
