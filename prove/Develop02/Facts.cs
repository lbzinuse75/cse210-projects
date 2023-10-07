using System.Reflection.Metadata;
using System.Collections.Generic;

// Create a class that will hold a list of facts and then Randomly select
// a fact for the user and display it to the console
public class Facts
{
    // Class Facts' attributes which is a list
    private List<string> facts = new List<string>();

    // the constructor holding the information of the list
    public Facts()
    {
        facts.Add("What is the price of milk today? How often do you buy milk? Any stories about Milk?");
        facts.Add("How much does a gallon of gas cost today?  How often do you fill up?  What kind of vehicle do you drive?  Any stories about your vehicle?");
        facts.Add("What movie or movies are playing in theaters today?  Have you seen them?  Have you watched any good movies lately, even old ones?");
        facts.Add("What is in the news today?  How has this affected you?  Has anything significant happened lately that affected you?");
        facts.Add("What political issues or events have recently caught your attention, and why?");
        facts.Add("How do you engage in political discussions or activities, such as voting, volunteering, or advocacy, and what motivates you to do so?");
        facts.Add("What is one of your apps on your phone?  Why do you have it and how do you use it?  How much time do you spend on it a day?");
        facts.Add("What are the last 10-20 photos on your phone?  What stories do these pictures hold?  What is a picture you could take today that tells a story?");
        facts.Add("What is your current job/career?  How long have you had it?  Who is one of your favorite co-workers?  What is your 5 year plan for job/career?");
        facts.Add("How has the world of education, including online learning and remote education, evolved over time?  How has this affected you?");
    }

    // method that calls the Random method to randomly go through the list and pick an indexed
    // prompt to display to the writer
    public string GetFactPrompt()
    {
        Random random = new Random();
        int factIndex = random.Next(facts.Count);
        return facts[factIndex];
    }
    
}