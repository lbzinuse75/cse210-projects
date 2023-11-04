using System.Diagnostics.Contracts;
using System.Reflection.Metadata.Ecma335;

public class Reflection : Activities
{
    private List<string> prompts = new List<string>();
    private List<string> reflectionQuestions = new List<string>();

    public Reflection(string activityName, string description) : base(activityName, description)
    {
        prompts.Add("Think of a time when you stood up for someone else.");
        prompts.Add("Think of a time when you did something really difficult.");
        prompts.Add("Think of a time when you helped someone in need.");
        prompts.Add("Think of a time when you did something truly selfless.");

        reflectionQuestions.Add("Why was this experience meaningful to you?");
        reflectionQuestions.Add("Have you ever done anything like this before?");
        reflectionQuestions.Add("How did you get started?");
        reflectionQuestions.Add("How did you feel when it was complete?");
        reflectionQuestions.Add("What made this time different than other times when you were not as successful?");
        reflectionQuestions.Add("What is your favorite thing abot this experience?");
        reflectionQuestions.Add("What could you learn from this experience that applies to other situations?");
        reflectionQuestions.Add("What did you learn about yourself through this experience?");
        reflectionQuestions.Add("How can you keep this experience in mind in the future?");
    }
        
    public void GetReadyR()
    {
        GetReady();
    }

    public void SpinnerR()
    {
        Spinner();
    }

    public void FinishR(string activityName)
    {
        Finish(activityName);
    }

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int randomIndex = random.Next(prompts.Count);
        return prompts[randomIndex];
    }

    public string GetRandomRefQue()
    {
        Random random = new Random();
        int randomIndex = random.Next(reflectionQuestions.Count);
        return prompts[randomIndex];
    }

    public void DisplayPrompt()
    {
        Console.WriteLine(GetRandomPrompt());
    }

    public void DisplayRandomRefQue()
    {
        Console.WriteLine(GetRandomRefQue());
    }
}