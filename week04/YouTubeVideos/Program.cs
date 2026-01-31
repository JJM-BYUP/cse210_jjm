using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        /*  Create at least 3-4 video instances with comments
                Sets appropriate values
                For each video: adds 3-4 comments
                Comments need commenter name and comment text
        */
        // Put each video in a list
        List<string> videos = new List<string>();

        Comment comment1a = new Comment("@deedoyle4069", "I'm 85..... THIS woman is fantastic! She says it the way things ARE. What a gal! I hope to be as delightfully humorous!");
        
        Comment comment1b = new Comment("@sallyharrington4569", "She is hysterical!! What an amazing woman.!!!");
        Comment comment1c = new Comment("@user-rd8ui9fn1x", "Still love Sis Hinckley, she was a class act!");
        Video vid1 = new Video("Sister Marjorie Hinckley’s Humor", "Declare My Word", 259, comment1a, comment1b, comment1c);
        
        
        Comment comment2a = new Comment("@angelamuircroft5181", "Jeanne may be gone, but her ability to make us laugh will always be her legacy.");
        Comment comment2b = new Comment("@janicew6222", "I never tire of hearing this funny lady, she is missed.");
        Comment comment2c = new Comment("@lawana960", "Jeanne is one of the few people who can make me laugh till I cry. I'm so thankful her family is still putting up these videos");
        Video vid2 = new Video("Left Brain vs. Right Brain", "Jeanne Robertson", 277, comment2a, comment2b, comment2c);


        // Comment comment7 = new Comment("@topazblahblah", "This is a great message. Be successful and honorable no matter what you do.");
        // Comment comment8 = new Comment("@KwadwoConda", "I loved this as well! Thanks for your wise words, Elder D. Todd Christofferson. I agree 100%.");
        // Comment comment9 = new Comment("@glo_moments", "In exercising faith, we don't have to know it all. We just have to trust in Him.");
        // Comment comment10 = new Comment("@best1213best", "Things I wish i get learned when I was in high school or college at least.");
        // Video vid3 = new Video("God guides us one step at a time", "@churchofjesuschrist", 120, comment7);

        vid1.AddVidCom();

        string video1 = Convert.ToString(vid1);
        string video2 = Convert.ToString(vid2);
        //string video3 = Convert.ToString(vid3._comments);
        videos.Add(video1);
        videos.Add(video2);
        //videos.Add(video3);

        

        // DISPLAY:
        /* Iterate through the list of videos
            For each one display:
                title, author, length, number of comments (from method), list
                all comments for that video - USE NumOfComments(); for iteration
        */
        foreach (string vid in videos)
        {
            Console.WriteLine(vid);
        }

        Console.WriteLine();
    }
}

