using System.Media;
using System.Collections.Generic;


public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hello Foundation4 World!");
        // Create videos
        Video video1 = new Video("Exploring the Mountains", "John Doe", 300);
        Video video2 = new Video("Cooking Pasta", "Jane Smith", 600);
        Video video3 = new Video("Yoga for Beginners", "Emily White", 900);

        // Add comments to videos
        video1.AddComment(new Comment("Alice", "Great video!"));
        video1.AddComment(new Comment("Bob", "Amazing views!"));
        video1.AddComment(new Comment("Charlie", "I want to go there too!"));

        video2.AddComment(new Comment("Dave", "Very helpful recipe."));
        video2.AddComment(new Comment("Eve", "Thanks for sharing!"));
        video2.AddComment(new Comment("Frank", "Delicious!"));

        video3.AddComment(new Comment("Grace", "Loved the yoga session."));
        video3.AddComment(new Comment("Hank", "Very relaxing."));
        video3.AddComment(new Comment("Ivy", "Just what I needed!"));

        // Put videos in a list
        List<Video> videos = new List<Video> { video1, video2, video3 };

        // Iterate through the list and display information
        foreach (var video in videos)
        {
            video.DisplayInfo();
        }
    }
}
