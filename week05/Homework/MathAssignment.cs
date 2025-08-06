using System.Reflection.Metadata.Ecma335;

class MathAssignment : Assignment
{
    private string _textbookSection;
    private string _problems;

    public MathAssignment(string name, string topic, string section, string problems) : base(name, topic)
    {
        this._textbookSection = section;
        this._problems = problems;
    }

    public string GetHomeworkList()
    {
        string returnString = $"Section: {_textbookSection}, Problems: {_problems} \n";

        return returnString;

    }
}