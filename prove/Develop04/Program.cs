using System;
using System.Diagnostics;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        string number = "0";
        while(number != "5")
        {
            // Welcome user and given a choice as to what activity they want to do
            {
                Console.WriteLine("");
                Console.WriteLine("Welcome to the Mindfulness Program");
                Console.WriteLine("Type the number next to the activity you would like to do.");
                Console.WriteLine("");
                Console.WriteLine("1. Breathing Activity");
                Console.WriteLine("2. Reflection Activity");
                Console.WriteLine("3. Listing Activity");
                Console.WriteLine("4. Gratitude Activity");
                Console.WriteLine("5. Quit");
                Console.WriteLine("");

                // User makes a choice
                Console.WriteLine("What actvitiy would you like to do?");
                number = Console.ReadLine();

                if(number == "1")
                {
                    Breathing b1 = new Breathing("Breathing", "This activity will help you relax by walking you through breathing in, holding, and breathing out slowly.  Clear your mind and focus on your breathing.");
                    b1.GetReadyB();
                    b1.StartBreathing();
                }
                else if(number == "2")
                {
                    Reflection r1 = new Reflection("Reflecting", "This activity will help you reflect on times in your life when you have shown strength and resilience.  This will help you recognize the power you have and how you can use it in other aspects of your life.");
                    r1.GetReadyR();
                    r1.DisplayPrompt();
                    r1.SpinnerR();
                    r1.DisplayRandomRefQue();
                    r1.SpinnerR();
                    r1.FinishR("Reflecting");
                }
                else if(number == "3")
                {
                    // Listing l1 = new Listing("Listing", "This activity will help you reflect on times in your life when you have shown strength and resilience.  This will help you recognize the power you have and how you can use it in other aspects of your life.");
                    // l1.GetReadyL();
                    // l1.StartListing();
                }
                else if (number =="4")
                {
                    // Gratitude g1 = new Gratitude("Gratitude", "This activity will help you reflect on times in your life when you have shown strength and resilience.  This will help you recognize the power you have and how you can use it in other aspects of your life.");
                    // g1.GetReadyG();
                    // g1.StartListing();
                }
                else if (number == "5")
                {
                    Console.WriteLine("Exiting the program.  Goodbye!");
                }
                else
                {
                    Console.WriteLine("Invalid choice.  Please select a number 1 through 5");
                }
            }
        }
    }
}