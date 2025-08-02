public class Comment()
{
    /* 
    Class Comment contains name of the commenter and the 
    text of the comment
    */

    /* attributes */
    private string _commenter;
    private string _comment;

    /* constructors
    public Comment()
    {
        _commenter = "My name";
        _comment = "This is a test comment";
    }
    /* for some unknown reason my constructors will not work - the program will not compile with them in place
    I cannot see a reason for it.  They are done exactly the same way as another program in which it compiles
    public Comment(string commenterName, string comment)
    {
        _commenter = commenterName;
        _comment = comment;
    }*/
    

    public void SetComment(string commenterName, string comment)
    {
        _commenter = commenterName;
        _comment = comment;
    }

    /* Display Comment */
    public void DisplayCommentWithName()
    {
        Console.WriteLine($"Name: {_commenter}");
        Console.WriteLine($"Comment: {_comment}");
    }

    /* Display Comment without the commenter's name */
    public void DisplayCommentWithoutName()
    {
        Console.WriteLine($"Comment: {_comment}");
    }
    
    public string CommentersName()
    {
        return _commenter;
    }

    public string CommentText()
    {
        return _comment;
    }
    
    
}