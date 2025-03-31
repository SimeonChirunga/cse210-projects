
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the YouTubeVideos Project.");

        // Create videos
        Video video1 = new Video("Video 1", "Matldah", 300);
        video1.AddComment(new Comment("Junior", "Great video!"));
        video1.AddComment(new Comment("Simeon", "I loved it!"));
        video1.AddComment(new Comment("Matldah", "Good job!"));

        Video video2 = new Video("Video 2", "Sibanda", 240);
        video2.AddComment(new Comment("Allison", "Excellent!"));
        video2.AddComment(new Comment("Haiven", "Well done!"));
        video2.AddComment(new Comment("Shannon", "Nice work!"));

        Video video3 = new Video("Video 3", "Niphi", 180);
        video3.AddComment(new Comment("Marve", "Good video!"));
        video3.AddComment(new Comment("Humphery", "I enjoyed it!"));
        video3.AddComment(new Comment("Kudzai", "Great job!"));

        // Add videos to a list
        List<Video> videos = new List<Video> { video1, video2, video3 };

        // Display video information
        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video._title}");
            Console.WriteLine($"Author: {video._author}");
            Console.WriteLine($"Length: {video._length} seconds");
            Console.WriteLine($"Comment Count: {video.GetCommentCount()}");
            Console.WriteLine("Comments:");
            foreach (Comment comment in video._comments)
            {
                Console.WriteLine($" - {comment._name}: {comment._text}");
            }
            Console.WriteLine();
        }
    }
}
