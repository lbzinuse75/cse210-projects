using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("1234 S Main", "Detroit", "Michigan", "48127");
        Event event1 = new LectureEvent("Lecture Event", "Regional Conference", "January 20, 2024", "6 pm", address1, "Elder Regional Authority", 5000);
        Console.WriteLine("Standard Message");
        Console.WriteLine(event1.StandardMessage());
        Console.WriteLine("");

        Console.WriteLine("FullMessage");
        Console.WriteLine(event1.FullMessage());
        Console.WriteLine("");

        Console.WriteLine("ShortMessage");
        Console.WriteLine(event1.ShortMessage());
        Console.WriteLine("");


        Address address2 = new Address("567 Celestial Street", "Paris", "France", "70123");
        Event event2 = new ReceptionEvent("Reception Event", "Missionary Reunion", "October 5, 2024", "1 pm", address2, "RSVP_ReceptionEvent@gmail.com");
        Console.WriteLine("Standard Message");
        Console.WriteLine(event2.StandardMessage());
        Console.WriteLine("");

        Console.WriteLine("FullMessage");
        Console.WriteLine(event2.FullMessage());
        Console.WriteLine("");

        Console.WriteLine("ShortMessage");
        Console.WriteLine(event2.ShortMessage());
        Console.WriteLine("");


        Address address3 = new Address("525 S Center Street", "Rexburg", "Idaho", "83460");
        Event event3 = new OutdoorEvent("Outdoor Event", "BYU-I Class Reunion", "June 8, 2024", "10 am", address3, "Sunny and Clear");
        Console.WriteLine("Standard Message");
        Console.WriteLine(event3.StandardMessage());
        Console.WriteLine("");

        Console.WriteLine("FullMessage");
        Console.WriteLine(event3.FullMessage());
        Console.WriteLine("");

        Console.WriteLine("ShortMessage");
        Console.WriteLine(event3.ShortMessage());
        Console.WriteLine("");
    }
}