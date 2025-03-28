using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create comments
            Comment message1 = new Comment("Alice", "Nice video!");
            Comment message2 = new Comment("Victor", "Interesting video!");
            Comment message3 = new Comment("James", "Cool video!");

            // Create videos
            Videos video1 = new Videos("Dancing Crib Walk", "Henry", 90);
            Videos video2 = new Videos("Singing High Pitch", "Sara", 100);
            Videos video3 = new Videos("Bubble Making", "Mick", 70);

            // Add comments to videos
            video1.AddComment(message1);
            video1.AddComment(message2);

            video2.AddComment(message3);
            video2.AddComment(message1);

            video3.AddComment(message2);

            // Create a list of all videos
            List<Videos> allVideos = new List<Videos> { video1, video2, video3 };

            // Iterate through all videos and display information
            foreach (Videos video in allVideos)
            {
                Console.WriteLine($"Title: {video.Title}");
                Console.WriteLine($"Author: {video.Author}");
                Console.WriteLine($"Length of video: {video.Length} seconds");
                Console.WriteLine($"Number of comments: {video.GetNumberOfComments()}");
                Console.WriteLine($"Comments:");

                // Display all comments for the video
                foreach (Comment c in video.GetMessages())
                {
                    Console.WriteLine($"{c.CommenterName}: {c.CommentText}");
                }

                Console.WriteLine(); // Add a blank line between videos
            }
        }
    }
}
