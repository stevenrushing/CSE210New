using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video();
        video1.SetTitle("Minecraft House Tutorial");
        video1.SetAuthor("BobPlays");
        video1.SetLength(347);
        video1.AddComment(new Comment("Tim", "this helped me so much"));
        video1.AddComment(new Comment("Jake", "cool build"));
        video1.AddComment(new Comment("Sara", "I tried this and it worked!"));
        videos.Add(video1);

        Video video2 = new Video();
        video2.SetTitle("How to Change a Tire");
        video2.SetAuthor("CarGuyMike");
        video2.SetLength(512);
        video2.AddComment(new Comment("Greg", "saved my life last week"));
        video2.AddComment(new Comment("Lisa", "very helpful thank you"));
        video2.AddComment(new Comment("Dan", "good video"));
        video2.AddComment(new Comment("Amy", "should have watched this sooner lol"));
        videos.Add(video2);

        Video video3 = new Video();
        video3.SetTitle("Easy Chocolate Chip Cookies");
        video3.SetAuthor("BakingWithJen");
        video3.SetLength(743);
        video3.AddComment(new Comment("Kevin", "made these and they were great"));
        video3.AddComment(new Comment("Mia", "so good!!"));
        video3.AddComment(new Comment("Tom", "added extra chocolate chips, 10/10"));
        videos.Add(video3);

        Video video4 = new Video();
        video4.SetTitle("Funny Cat Compilation");
        video4.SetAuthor("CatsOfYouTube");
        video4.SetLength(198);
        video4.AddComment(new Comment("Zach", "I cant stop watching this"));
        video4.AddComment(new Comment("Bella", "the one at 1:20 got me"));
        video4.AddComment(new Comment("Sam", "my cat does this too haha"));
        videos.Add(video4);

        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video.GetTitle()}");
            Console.WriteLine($"Author: {video.GetAuthor()}");
            Console.WriteLine($"Length: {video.GetLength()} seconds");
            Console.WriteLine($"Number of Comments: {video.GetNumberOfComments()}");
            Console.WriteLine("Comments:");
            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($"  {comment.GetName()}: {comment.GetText()}");
            }
            Console.WriteLine();
        }
    }
}
