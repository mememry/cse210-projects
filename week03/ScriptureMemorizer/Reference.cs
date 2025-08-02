public class Reference
{
    private string _book;
    public int _chapter;
    public int _startVerse;
    public int _endVerse;

    public Reference()
    {
        _book = "2 Kings";
        _chapter = 6;
        _startVerse = 16;
        _endVerse = 16;
    }

    public Reference(string book)
    {
        _book = book;
        _chapter = 1;
        _startVerse = 1;
        _endVerse = 1;
    }
    public Reference(string book, int chapter, int startVerse)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = startVerse;
        _endVerse = startVerse;
    }

    public Reference(string book, int chapter, int startVerse, int endVerse = 0)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = startVerse;
        _endVerse = endVerse;
    }

    public string GetReferenceString()
    {
        string reference = "";
        if (_endVerse > _startVerse)
        {
            return reference = $"{_book} {_chapter}:{_startVerse}-{_endVerse}";
        }
        else
        {
            return reference = $"{_book} {_chapter}:{_startVerse}";
        }
    }
}