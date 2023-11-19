using System;
using System.ComponentModel;
using System.Drawing;
using System.Formats.Asn1;
using System.Globalization;
using System.Threading.Tasks.Dataflow;

class Program
{
    static void Main(string[] args)
    {
        int score = 0;
        List<Goal> goalsList = new List<Goal>();
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
                case "1": //create a goal
                    Console.WriteLine("The types of Goals are: ");
                    Console.WriteLine("   1. Simple Goal");
                    Console.WriteLine("   2. Eternal Goal");
                    Console.WriteLine("   3. Checklist Goal");
                    Console.WriteLine("Which type of goal would you like to creat? ");
                    string goalNumber = Console.ReadLine();
                    
                    if(goalNumber == "1") //simple
                    {
                        Console.WriteLine("What is the name of your goal? ");
                        string name = Console.ReadLine();
                        Console.WriteLine("What is a short description of it? ");
                        string description = Console.ReadLine();
                        Console.WriteLine("What is the amount of points associated with this goal? ");
                        int points = int.Parse(Console.ReadLine());
                        Simple simple = new Simple("Simple", name, description, points, false);   
                        goalsList.Add(simple);     
                    }   

                    else if (goalNumber == "2") //eternal
                    {
                        Console.WriteLine("What is the name of your goal? ");
                        string name = Console.ReadLine();
                        Console.WriteLine("What is a short description of it? ");
                        string description = Console.ReadLine();
                        Console.WriteLine("What is the amount of points associated with this goal? ");
                        int points = int.Parse(Console.ReadLine());
                        Eternal eternal = new Eternal("Eternal", name, description, points, false);   
                        goalsList.Add(eternal);
                    }

                    else if (goalNumber == "3") //checklist
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
                        Checklist checkList = new Checklist("Checklist", name, description, points, times, bonus, false, "0");   
                        goalsList.Add(checkList);
                    }
                    
                    else
                    {
                        Console.WriteLine("Invalid goal type.");
                    }
                    break;

                case "2": //list goals
                    Console.WriteLine("The goals are:");
                    foreach (Goal goal in goalsList)
                    {
                        Console.WriteLine(goal.GoalDisplay());
                    }
                    break;
                  
                case "3": // save goals
                    FileManager.SaveGoalToFile(goalsList);
                    break;
                case "4": // load goals
                    Console.WriteLine("What is the filename for the goal file?");
                    string fileNameAnswer = Console.ReadLine();
                    goalsList = FileManager.Load(fileNameAnswer);
                    break;
                case "5": //record event
                    foreach (Goal goal in goalsList)
                    {
                        Console.WriteLine(goal.GoalDisplay());
                    }
                    
                    Console.WriteLine("Which goal did you accomplish?");
                    string goalAnswer = Console.ReadLine();

                    Goal recordingGoal = goalsList[int.Parse(goalAnswer)-1];
                    
                    if (recordingGoal.GetGoalType() == "Simple")
                    {
                        recordingGoal.SetComplete();
                        int points = recordingGoal.RecordEvent();
                        score = score + points;
                    }

                    else if (recordingGoal.GetGoalType() == "Eternal")
                    {
                        int points = recordingGoal.RecordEvent();
                        score = score + points;
                    }

                    else if (recordingGoal.GetGoalType() == "Checklist")
                    {
                        int points = recordingGoal.RecordEvent();
                        score = score + points;
                    }
                    break;
                case "6": // quit
                    Console.WriteLine("Good Bye");
                    break;
                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }        
        }    
    }
}