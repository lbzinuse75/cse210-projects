using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activityList = new List<Activity>();
        Activity runActivity = new RunActivity("12/4/2023", 30, 3);
        activityList.Add(runActivity);
        Activity bikeActivity = new BikeActivity("12/2/2023", 60, 15);
        activityList.Add(bikeActivity);
        Activity swimActivity = new SwimActivity("11/30/2023", 30, 20);
        activityList.Add(swimActivity);

        foreach (Activity activity in activityList)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}