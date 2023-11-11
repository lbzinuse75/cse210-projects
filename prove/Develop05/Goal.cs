using System.ComponentModel;
using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;

public class Goal
{
    protected string _name;
    protected string _description;
    protected int _points;
    protected string _times;
    protected int _bonus;

    public Goal(string name, string description, int points)
    {
        _name = name;
        _description = description;
        _points = points;
    }

    public Goal(string name, string description, int points, string times, int bonus)
    {
        _name = name;
        _description = description;
        _points = points;
        _times = times;
        _bonus = bonus;
    }

    public void GoalsMenu()
    {
        Console.WriteLine("The types of Goals are: ");
        Console.WriteLine("   1. Simple Goal");
        Console.WriteLine("   2. Eternal Goal");
        Console.WriteLine("   3. Checklist Goal");
        Console.WriteLine("Which type of goal would you like to creat? ");
        string goalNumber = Console.ReadLine();

        if(goalNumber == "1")
        {
            Console.WriteLine("What is the name of your goal? ");
            string _name = Console.ReadLine();
            Console.WriteLine("What is a short description of it? ");
            string _description = Console.ReadLine();
            Console.WriteLine("What is the amount of points associated with this goal? ");
            int _points = int.Parse(Console.ReadLine());    
        }
        else if(goalNumber == "2")
        {
            Console.WriteLine("What is the name of your goal? ");
            string _name = Console.ReadLine();
            Console.WriteLine("What is a short description of it? ");
            string _description = Console.ReadLine();
            Console.WriteLine("What is the amount of points associated with this goal? ");
            int _points = int.Parse(Console.ReadLine()); 
        }
        else if(goalNumber == "3")
        {
            Console.WriteLine("What is the name of your goal? ");
            string _name = Console.ReadLine();
            Console.WriteLine("What is a short description of it? ");
            string _description = Console.ReadLine();
            Console.WriteLine("What is the amount of points associated with this goal each time completed? ");
            int _points = int.Parse(Console.ReadLine());
            Console.WriteLine("How many times does this goal need to be accomplished for a bonus? ");
            string _times = Console.ReadLine();
            Console.WriteLine("What is the bonus for accomplishing it that many times? ");
            int _bonus = int.Parse(Console.ReadLine());
        }
    }
    public void GoalDisplay(string name, string description, int points)
    {
        Console.Write($"{goalItem}. [{complete}] {_name} ({_description})");
    }  
}