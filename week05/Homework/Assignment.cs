class Assignment
{
    private string _name;
    private string _topic;

    public Assignment(string name, string topic)
    {
        this._name = name;
        this._topic = topic;
    }

    public string GetSummary()
    {
        string summary = $"{_name}, {_topic} \n";
        return summary;
    }

    public void CreateAssignment(string name, string topic)
    {
        this._name = name;
        this._topic = topic;
    }

    public string GetStudentName()
    {
        return _name;
    }
}