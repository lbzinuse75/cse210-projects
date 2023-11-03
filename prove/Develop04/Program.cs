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
                    Breathing a1 = new Breathing("Breathing", "This activity will help you relax by walking you through breathing in, holding, and breathing out slowly.  Clear your mind and focus on your breathing.");
                    a1.GetReadyB();
                    a1.StartBreathing();
                }
                else if(number == "2")
                {

                }
                else if(number == "3")
                {

                }
                else if (number =="4")
                {

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