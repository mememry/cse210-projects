using System.Reflection.Metadata.Ecma335;

class WritingAssignment : Assignment
{
    private string _title;

    public WritingAssignment(string name, string topic, string title) : base(name, topic)
    {
        this._title = title; ;
    }

    public string GetWritingInformation()
    {
        
        string returnString = $"Student: {GetStudentName()}\n Title: {_title} \n";

        return returnString;

    }
}