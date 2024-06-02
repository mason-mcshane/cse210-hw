using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video v1 = new Video ("Destiny 2 Raid Guide Video #1", "Ben Robinson", 300);
        v1._comments.Add(new Comment("Anne", "Very informative!"));
        v1._comments.Add(new Comment("Billy", "Great Job!"));
        v1._comments.Add(new Comment("Clark", "Thank you for your hard work!"));
        v1._comments.Add(new Comment("Dale","Solid animation!"));


        Video v2 = new Video ("Destiny 2 Raid Guide Video #2", "Philip Tomlin", 200);
        v2._comments.Add(new Comment("Edward", "Very visual!"));
        v2._comments.Add(new Comment("Fred", "I learned a lot from this!"));
        v2._comments.Add(new Comment("George", "1st comment!"));
        v2._comments.Add(new Comment("Hale", "Can you try explaining this concept next?"));

        Video v3 = new Video ("Destiny 2 Raid Guide Video #3", "Dang Long", 500);
        v3._comments.Add(new Comment("Issac", "I like this activity!"));
        v3._comments.Add(new Comment("Julian", "Had so much fun with my friends!"));
        v3._comments.Add(new Comment("Kearon", "10/10 Video!"));
        v3._comments.Add(new Comment("Lemuel", "Hasn't this idea been done before?"));

        Video v4 = new Video ("Destiny 2 Raid Guide Video #4", "Paul Berkey", 100);
        v4._comments.Add(new Comment("Michael", "How long did it take you to make this?"));
        v4._comments.Add(new Comment("Nathan", "Which class do you like best?"));
        v4._comments.Add(new Comment("Oliver", "How long did it take you to beat this activity?"));
        v4._comments.Add(new Comment("Phil", "Can you get a team to help me out sometime?"));
       
        videos.Add(v1);
        videos.Add(v2);
        videos.Add(v3);
        videos.Add(v4);

        foreach(Video video in videos)
        {   
            Console.WriteLine();
            Console.WriteLine($"Video Title: {video.GetTitle()}");
            Console.WriteLine($"Author: {video.GetAuthor()}");
            Console.WriteLine($"Video Duration: {video.GetLength()} seconds");
            Console.WriteLine($"This video has {video.GetCommentCount()} comments\n");
            Console.WriteLine("COMMENTS:");

            foreach(Comment comment in video._comments)
            { 
                Console.WriteLine($"{comment.GetCommenter()}: {comment.GetText()}"); 
            }
        }
    }
}