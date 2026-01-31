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
                Put each video instance in a List
        */

        // Put each video in a list
        List<string> videos = new List<string>();

        //VIDEO 1:
        Comment comment1a = new Comment("@deedoyle4069", "I'm 85..... THIS woman is fantastic! She says it the way things ARE. What a gal! I hope to be as delightfully humorous!");
        Comment comment1b = new Comment("@sallyharrington4569", "She is hysterical!! What an amazing woman.!!!");
        Comment comment1c = new Comment("@user-rd8ui9fn1x", "Still love Sis Hinckley, she was a class act!");
        Video vid1 = new Video("Sister Marjorie Hinckley’s Humor", "Declare My Word", 259, comment1a, comment1b, comment1c);

        vid1.DisplayVidInfo();


        //VIDEO 2:
        Comment comment2a = new Comment("@angelamuircroft5181", "Jeanne may be gone, but her ability to make us laugh will always be her legacy.");
        Comment comment2b = new Comment("@janicew6222", "I never tire of hearing this funny lady, she is missed.");
        Comment comment2c = new Comment("@lawana960", "Jeanne is one of the few people who can make me laugh till I cry. I'm so thankful her family is still putting up these videos");
        Video vid2 = new Video("Left Brain vs. Right Brain", "Jeanne Robertson", 277, comment2a, comment2b, comment2c);

        vid2.DisplayVidInfo();


        //VIDEO 3:
        Comment comment3a = new Comment("@topazblahblah", "This is a great message. Be successful and honorable no matter what you do.");
        Comment comment3b = new Comment("@KwadwoConda", "I loved this as well! Thanks for your wise words, Elder D. Todd Christofferson. I agree 100%.");
        Comment comment3c = new Comment("@glo_moments", "In exercising faith, we don't have to know it all. We just have to trust in Him.");
        Video vid3 = new Video("God guides us one step at a time", "@churchofjesuschrist", 120, comment3a, comment3b, comment3c);

        vid3.DisplayVidInfo();


        //string video1 = Convert.ToString(vid1);
        //string video2 = Convert.ToString(vid2);
        //string video3 = Convert.ToString(vid3._comments);

        //videos.Add(video1);
        //videos.Add(video2);
        //videos.Add(video3);

    }
}

