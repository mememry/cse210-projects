using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videoList = new List<Video>();
        List<string> videoNames = ["kitten", "puppy", "trail cam", "city folks doing stupid things"];
        List<string> authorNames = ["KrazyKatLady", "PuppyLover", "WildLife", "Bob"];
        List<int> lengths = [25, 120, 375, 300];

        /* 
        Create 3 - 4 videos using method from public class video
        Create 3 - 4 comments using method from public class Comment
        */
        do
        {
            string videoName = $"{videoNames[videoList.Count()]}";
            string author = $"{authorNames[videoList.Count()]}";
            int length = lengths[videoList.Count()];
            Video newVideo;
            //newVideo.SetVideo(videoName, author, length);
            //videoList.Add(newVideo);


        } while (videoList.Count() < 4);

        /*
            Iterate through video list and display title, author, length, number of comments
            list of comments for each video
            */
            Console.WriteLine("Hello World! This is the YouTubeVideos Project.");
    }
}