using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Video 1
        Video video1 = new Video("BBQ on the terrace", "DonParrillero", 900);
        video1.AddComment(new Comment("Lucho", "That BBQ looks great 🔥"));
        video1.AddComment(new Comment("Carla", "No sausages? haha"));
        video1.AddComment(new Comment("Nico", "I am hungry now"));
        video1.AddComment(new Comment("Mili", "Do you use wood or coal?"));

        // Video 2
        Video video2 = new Video("Mate in Posadas", "GuadaMisiones", 420);
        video2.AddComment(new Comment("Pablo", "Nice view of the river 😍"));
        video2.AddComment(new Comment("Sofi", "The mate is cold haha"));
        video2.AddComment(new Comment("Juan", "So Misiones style 💚"));
        video2.AddComment(new Comment("Ceci", "Where is the chipa?"));

        // Video 3
        Video video3 = new Video("Best Messi goals", "FutbolArgento", 600);
        video3.AddComment(new Comment("Martin", "I love Messi"));
        video3.AddComment(new Comment("Flor", "Messi forever 💙🤍💙"));
        video3.AddComment(new Comment("Gabi", "The best in history"));
        video3.AddComment(new Comment("Romi", "I cry again"));

        // Video 4
        Video video4 = new Video("Walking San Telmo", "PorteñoTraveler", 480);
        video4.AddComment(new Comment("Ale", "The market is classic"));
        video4.AddComment(new Comment("Lu", "I want choripan now"));
        video4.AddComment(new Comment("Maru", "Nice old streets"));
        video4.AddComment(new Comment("Fede", "Good video, bro"));

        // List of videos
        List<Video> videos = new List<Video>() { video1, video2, video3, video4 };

        // Show info
        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length: {video.Length} seconds");
            Console.WriteLine($"Number of comments: {video.GetNumberOfComments()}");
            Console.WriteLine("Comments:");
            foreach (Comment comment in video.Comments)
            {
                Console.WriteLine($" - {comment.Name}: {comment.Text}");
            }
            Console.WriteLine();
        }
    }
}
