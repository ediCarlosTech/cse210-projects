using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("This is the YouTubeVideos Project.\n");

        List<Video> _videos = new List<Video>();

        Video video1 = new Video("Learning C#", "Mr John", 360);
        Video video2 = new Video("Learning Programming with Classes using C#", "Mr BYU Grader", 500);
        Video video3 = new Video("Getting job as Developer", "Mr Lukas", 350);

        Comment video1Comment1 = new Comment("John", "What a great video1. Thank you!");
        Comment video1Comment2 = new Comment("Mark", "Hi! Thank you so much for your video1. It helped me a lot.");
        Comment video1Comment3 = new Comment("Matheu", "Thank you so much for your video1. I am looking forward for the next. :)");

        video1.AddComment(video1Comment1);
        video1.AddComment(video1Comment2);
        video1.AddComment(video1Comment3);

        Comment video2Comment1 = new Comment("Edi", "What a great video 2. Thank you!");
        Comment video2Comment2 = new Comment("Mark", "Hi! Thank you so much for your video 2. It helped me a lot.");
        Comment video2Comment3 = new Comment("Matheu", "Thank you so much for your video 2. I am looking forward for the next. :)");

        video2.AddComment(video2Comment1);
        video2.AddComment(video2Comment2);
        video2.AddComment(video2Comment3);

        Comment video3Comment1 = new Comment("Edi", "What a great video 3. Thank you!");
        Comment video3Comment2 = new Comment("Mark", "Hi! Thank you so much for your video 3. It helped me a lot.");
        Comment video3Comment3 = new Comment("Matheu", "Thank you so much for your video 3. I am looking forward for the next. :)");

        video3.AddComment(video3Comment1);
        video3.AddComment(video3Comment2);
        video3.AddComment(video3Comment3);

        _videos.Add(video1);
        _videos.Add(video2);
        _videos.Add(video3);

        foreach (Video video in _videos)
        {
            System.Console.WriteLine(video.GetVideoDetails());
        }

    }
}