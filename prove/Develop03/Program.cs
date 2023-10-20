using System;
using System.Formats.Asn1;
using System.Globalization;
using System.Xml;

class Program
{
    static void Main(string[] args)
    // Welcome user and given a choice as to what scripture they want to practice memorizing
    {
        Console.WriteLine("Welcome to Memorizing Scripture Helper");
        Console.WriteLine("Type the number next to the scripture you want to work on.");
        Console.WriteLine("");
        Console.WriteLine("1 - Moses 1:39");
        Console.WriteLine("2 - Philippians 4:13");
        Console.WriteLine("3 - Proverbs 3:5-6");
        Console.WriteLine("4 - Doctrine and Covenants 64:33-34");
        Console.WriteLine("5 - 1 Nephi 3:7");
        Console.WriteLine("6 - John 14:15");
        Console.WriteLine("7 - Doctrine and Covenants 19:23");

        // User makes a choice
        Console.WriteLine("What scripture would you like to work on?");
        string number = Console.ReadLine();

        // Variable start out as null
        Reference reference = null;
        Scripture scripture = null;

        // Scripture References
        switch (number)
        {
            case "1":
                reference = new Reference("Moses", "1", "39");
                scripture = new Scripture("For behold, this is my work and my glory--to bring to pass the immortality and eternal life of man.", reference);
                break;
            case "2":        
                reference = new Reference("Philippians", "4", "13");
                scripture = new Scripture("I can do all things through Christ which strengtheneth me", reference);
                break;
            case "3":
                reference = new Reference("Proverbs", "3", "5", "6");
                scripture = new Scripture("Trust in the Lord with all thine heart; and lean not unto thine own understanding.  In all thy ways acknowledge him, and he shall direct thy paths.", reference);
                break;
            case "4":
                reference = new Reference("D&C", "64", "33", "34");
                scripture = new Scripture("Wherefore, be not weary in well-doing, for ye are laying the foundation of a great work.  And out of small things proceedeth that which is great.  Behold, the Lord requireth the heart and the willing mind", reference);
                break;
            case "5":
                reference = new Reference("1 Nephi", "3", "7");
                scripture = new Scripture("And it came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandment uto the children of men, save he shall prepare a way for them that they may accomplish the things which he commandeth them", reference);
                break;
            case "6":
                reference = new Reference("John", "14", "15");
                scripture = new Scripture("If ye love me, keep my commandments", reference);
                break;
            case "7":
                reference = new Reference("D&C", "19", "23");
                scripture = new Scripture("Learn of me, and listen to my words; walk in the meekness of my Spirit, and you shall have peace in me.", reference);
                break;
            default:
                Console.WriteLine("That number was not found.  Exiting program.");
                return;
        }

        // Displays the scripture and loops through lookig to see if the user enters "quit" or all the words are hidden then stops the 
        // program if either of those happen
        string answer; 
        while(true)
        {
            scripture.Display();
            Console.WriteLine("");
            Console.WriteLine("Press enter and words disappear or type 'quit' to finish:");
            Console.WriteLine("");
            answer = Console.ReadLine(); //looking for quit or enter

            if(answer == "quit" || scripture.WordsHidden())
                break;

            int counter = 0;
            while(counter < 3 && !scripture.WordsHidden())
            {
                scripture.HideWord();
                counter++;
            } 
        }
    }
}