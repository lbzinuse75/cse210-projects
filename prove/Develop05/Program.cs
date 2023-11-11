using System;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        int score = 0;
        Console.WriteLine("");
        Console.WriteLine($"You have {score} points.");
        Console.WriteLine("");
        Console.WriteLine("Menu Options:");
        Console.WriteLine("   1. Create New Goal");
        Console.WriteLine("   2. List Goals");
        Console.WriteLine("   3. Save Goals");
        Console.WriteLine("   4. Load Goals");
        Console.WriteLine("   5. Record Event");
        Console.WriteLine("   6. Quit");
        Console.Write("Select a choice from the menu: ");
        string number = Console.ReadLine();

        string name = "";
        string description = "";
        int points = 0;

        switch (number)
        {
            case "1":
                Goal goal = new Goal(name, description, points);
                goal.GoalsMenu();
                break;
            case "2":
                break;
            case "3":
                break;
            case "4":
                break;
            case "5":
                break;
            case "6":
                break;
        }    
    }
}