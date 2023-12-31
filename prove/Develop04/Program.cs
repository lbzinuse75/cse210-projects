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
                    b1.GetReady();
                    b1.StartBreathing();
                    b1.Finish("Breathing");
                }
                else if(number == "2")
                {
                    Reflection r1 = new Reflection("Reflecting", "This activity will help you reflect on times in your life when you have shown strength and resilience.  This will help you recognize the power you have and how you can use it in other aspects of your life.");
                    r1.GetReadyR();
                    r1.StartReflection();
                    r1.Finish("Reflecting");
                }
                else if(number == "3")
                {
                    Listing l1 = new Listing("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
                    l1.GetReady();
                    l1.StartListing();
                    l1.Finish("Listing");
                }
                else if (number =="4")
                {
                    Gratitude g1 = new Gratitude("Gratitude", "This activity will help you reflect on the things you are grateful.  This will help you recognize the power of gratitude and help you reflect on the many blessings you enjoy in your life.");
                    g1.GetReady();
                    g1.StartGratitude();
                    g1.Finish("Gratitude");
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