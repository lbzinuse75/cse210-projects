using System;
using System.Globalization;
using System.Transactions;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        Console.WriteLine("Enter a list of numbers, type 0 when finished. ");

        int inputNumber = -1;

        while (inputNumber != 0)
        {
            Console.Write("Enter number: ");
            string userResponse = Console.ReadLine();
            inputNumber = int.Parse(userResponse);
            
            if (inputNumber != 0)
            {
                numbers.Add(inputNumber);
            }
        }            

        int sum = 0; 
        foreach (int number in numbers)
        {
            sum += number;
        }
        Console.WriteLine($"The sum:  {sum}");

        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average: {average}");

        int largest = numbers[0];
        foreach (int number in numbers)
        {
            if (number > largest)
            {
            largest = number;
            }
        }
        Console.WriteLine($"The largest number: {largest}"); 

        int smallest = numbers[0];
        foreach (int number in numbers)
        {
            if (number < smallest)
            {
            smallest = number;
            }
        }
        Console.WriteLine($"The smallest number: {smallest}"); 
     }   
}