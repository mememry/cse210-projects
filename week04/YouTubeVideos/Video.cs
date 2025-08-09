public class Video
{
    /* 
    Video class contains title, author, and length of video (in seconds)
    and a list of comments
    methods return video title, display information for video, and return the number of comments
    */

    // attributes
    private string _videoTitle;
    private string _videoAuthor;
    private int _length;
    private List<Comment> _comments = new List<Comment>();

    /*constructor*/
    public Video(string title, string author, int length)
    {
        this._videoTitle = title;
        this._videoAuthor = author;
        this._length = length;
    }


    /* set video data */
    public void SetVideo(string videoTitle, string videoAuthor, int length)
    {
        _videoTitle = videoTitle;
        _videoAuthor = videoAuthor;
        _length = length;
    }

    /*
    Add Comment
    */
    public void AddComment(string commenterName, string comment)
    {
        Comment _newComment = new Comment(commenterName, comment);
        _comments.Add(_newComment);
    }

    /* 
    Number of Comments - returns an integer
    */
    public int CommentCount()
    {
        return _comments.Count();
    }

    /*
    Display Video Data
    */
    public void DisplayVideoData()
    {
        Console.WriteLine($"Title:  {_videoTitle}");
        Console.WriteLine($"Author: {_videoAuthor}");
        Console.WriteLine($"Length: {_length} seconds");
        Console.WriteLine();
    }

    public void DisplayVideoDataWithComments()
    {
        Console.WriteLine($"Title:  {_videoTitle}");
        Console.WriteLine($"Author: {_videoAuthor}");
        Console.WriteLine($"Length: {_length} seconds");
        Console.WriteLine();
        foreach (Comment comment in _comments)
        {
            comment.DisplayCommentWithName();
        }
        Console.WriteLine();
    }


}