using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videoList = new List<Video>();
        List<string> videoNames = ["kitten", "puppy", "trail cam", "city folks doing stupid things"];
        List<string> authorNames = ["KrazyKatLady", "PuppyLover", "WildLife", "Bob"];
        List<int> lengths = [25, 120, 375, 300];
        List<string> commentAuthors = ["WildMan34", "BoredScroller", "EveryCommenter", "ImTalkingHere", "AnotherCommenter"];
        List<string> commentList = ["Funny!", "How rude!", "I don't get it", "What was that?", "I can't stop watching", "Keep it coming!", "Encore!", "I can't believe I watched the whole thing.", "I have to share this."];

        /* 
        Create 3 - 4 videos using method from public class video
        */

        do
        {
            string videoName = $"{videoNames[videoList.Count()]}";
            string author = $"{authorNames[videoList.Count()]}";
            int length = lengths[videoList.Count()];
            Video newVideo = new Video(videoName, author, length);
            videoList.Add(newVideo);

        } while (videoList.Count() < 4);

        /*
        Create 3 - 4 comments using method from public class Comment
        */
        
        foreach (Video thisVideo in videoList)
        {
            Random randomNumber = new Random();
            int numberOfComments = randomNumber.Next(3, 6);
            for (int counter = 1; counter <= numberOfComments; counter++)
            {
                int itemNumber = randomNumber.Next(0, 9);
                string thisCommentText = commentList[itemNumber];
                int authorNumber = randomNumber.Next(0, 5);
                string thisAuthor = commentAuthors[authorNumber];
                thisVideo.AddComment(thisAuthor, thisCommentText);
            }
        }

        /*
        Iterate through video list and display title, author, length, number of comments
        list of comments for each video
        */
        foreach (Video thisVideo in videoList)
        {
            thisVideo.DisplayVideoDataWithComments();
        }

    }
}