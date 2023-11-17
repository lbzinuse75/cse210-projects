using System;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        int score = 0;
        // FileManager myFile = new FileManager();
        // List<Goal> goalsList = new List<Goal>();
        string number = "0";

        while(number != "6")
        {
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
            number = Console.ReadLine();

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
                        Goal simple = new Goal(name, description, points);   
                        Goal.SaveGoalInList(simple);     
                    }   

                    else if(goalNumber == "2")
                    {
                        Console.WriteLine("What is the name of your goal? ");
                        string name = Console.ReadLine();
                        Console.WriteLine("What is a short description of it? ");
                        string description = Console.ReadLine();
                        Console.WriteLine("What is the amount of points associated with this goal? ");
                        int points = int.Parse(Console.ReadLine());
                        Goal eternal = new Goal(name, description, points);   
                        Goal.SaveGoalInList(eternal);
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
                        Goal checkList = new Goal(name, description, points);   
                        Goal.SaveGoalInList(checkList);
                    }
                    
                    else
                    {
                        Console.WriteLine("Invalid goal type.");
                    }
                    break;

                case "2":
                    List<Goal> goalsList = Goal.GetGoalsList();
                    Console.WriteLine("The goals are:");
                    foreach (Goal goal in goalsList)
                    {
                        Console.WriteLine(goal.GoalDisplay());
                    }
                    break;
                    // Console.WriteLine(simpleGoal.GoalDisplay());

                    // foreach(Goal goal in goalsList)
                    // {
                    //     // simpleGoal.GoalDisplay();
                    //     // Goal.saveGoalInList(simpleGoal);  
                    //     goal.GoalDisplay();
                    // }
                    // break;
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
}