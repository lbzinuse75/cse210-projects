using System;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        int score = 0;
        List<Goal> goalsList = new List<Goal>();
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

        switch (number)
        {
            case "1":
                Console.WriteLine("The types of Goals are: ");
                Console.WriteLine("   1. Simple Goal");
                Console.WriteLine("   2. Eternal Goal");
                Console.WriteLine("   3. Checklist Goal");
                Console.WriteLine("Which type of goal would you like to creat? ");
                string goalNumber = Console.ReadLine();

                if(goalNumber == "1")
                {
                    Console.WriteLine("What is the name of your goal? ");
                    string name = Console.ReadLine();
                    Console.WriteLine("What is a short description of it? ");
                    string description = Console.ReadLine();
                    Console.WriteLine("What is the amount of points associated with this goal? ");
                    int points = int.Parse(Console.ReadLine());
                    Goal simpleGoal = new Goal(name, description, points);
                    
                }   

                else if(goalNumber == "2")
                {
                    Console.WriteLine("What is the name of your goal? ");
                    string name = Console.ReadLine();
                    Console.WriteLine("What is a short description of it? ");
                    string description = Console.ReadLine();
                    Console.WriteLine("What is the amount of points associated with this goal? ");
                    int points = int.Parse(Console.ReadLine());
                }

                else if (goalNumber == "3")
                {
                    Console.WriteLine("What is the name of your checklist goal? ");
                    string name = Console.ReadLine();
                    Console.WriteLine("What is a short description of it? ");
                    string description = Console.ReadLine();
                    Console.WriteLine("What is the amount of points associated with this goal each time completed? ");
                    int points = int.Parse(Console.ReadLine());
                    Console.WriteLine("How many times does this goal need to be accomplished for a bonus? ");
                    string times = Console.ReadLine();
                    Console.WriteLine("What is the bonus for accomplishing it that many times? ");
                    int bonus = int.Parse(Console.ReadLine());
                }
                
                else
                {
                    Console.WriteLine("Invalid goal type.");
                }

                
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
            default:
                Console.WriteLine("Invalid choice.");
                break;
        }    
    }
}