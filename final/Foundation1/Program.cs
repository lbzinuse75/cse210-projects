using System;
using System.Globalization;
using System.Reflection.PortableExecutable;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videoList = new List<Video>();

        Video video1 = new Video("Camping with the 'Light of Truth Torch'", "Enos", 35);
        video1._comments.Add(new Comment("Anthony Aaronic", "This is the best flashlight"));
        video1._comments.Add(new Comment("Daniel Deacon", "Wonderful illumination"));
        video1._comments.Add(new Comment("Tyson Teacher", "Very durable dropped it a lot and still works"));
        video1._comments.Add(new Comment("Peter Priest", "Light weight and travels well in my pocket"));
        videoList.Add(video1);

        Video video2 = new Video("72 hour kits", "Sariah", 24);
        video2._comments.Add(new Comment("Betty Beehive", "Love the video, nice torch where what kind is it?"));
        video2._comments.Add(new Comment("Marsha MiaMaid", "I have been looking for a good 72 hour kit, this looks great."));
        video2._comments.Add(new Comment("Linda Larual", "This makes 72 hour kits look do able, thanks for the tips."));
        videoList.Add(video2);

        Video video3 = new Video("Cave Crawling", "Moroni", 60);
        video3._comments.Add(new Comment("Missionary Mike", "That torch really lights up the cave."));
        video3._comments.Add(new Comment("Missinoary Mandy", "I love going to caves, what a fun activity."));
        video3._comments.Add(new Comment("Yolanda Youth", "Where is the cave?  And how much was your light?"));
        video3._comments.Add(new Comment("Yoel Youth", "I have been there and love that cave."));
        videoList.Add(video3);

        Video video4 = new Video("Wedding Waiting", "Twelve Virgins", 70);
        video4._comments.Add(new Comment("Ester", "It took a long time to get prepared for my wedding and this torch kept bringing light to my life."));
        video4._comments.Add(new Comment("Rebekah", "I had to travel for my wedding and the light kept shining."));
        video4._comments.Add(new Comment("Rachel", "I didn't ever think I would finally get married but it finally happened."));
        video4._comments.Add(new Comment("Ruth", "I love a good wedding story, especially with light at the end."));
        videoList.Add(video4);

        foreach(Video video in videoList)
        {
            Console.Write(video.DisplayVideo());
            video.DisplayComment();
        }
    }
}