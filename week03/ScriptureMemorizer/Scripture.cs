using System.Runtime.CompilerServices;

public class Scripture
{
    private Reference _reference;
    private Words _scriptureWords = new Words();
    private List<int> _hiddenWordIndexes = new List<int>();

    public Scripture()
    {
        _reference = new Reference("1 Kings", 6, 16);
        _scriptureWords = new Words();
    }



    public Scripture(Reference reference, Words words)
    {
        _reference = reference;
        _scriptureWords = words;
    }

    public string GetScriptureString()
    {
        string scripture = "";
        int wordCount = _scriptureWords.ScriptureWordCount();
        for (int i = 0; i < wordCount; i++)
        {
            scripture += _scriptureWords.GetWord() + " ";
        }
        return scripture;
    }

    public void DisplayScripture()
    {
        Console.WriteLine(_reference.GetReferenceString());
        _scriptureWords.DisplayScriptureWords();
        Console.WriteLine();
    }

    public void HideWords()
    {
        int countWordsToHide = (_scriptureWords.ScriptureWordCount() / 5);
        _scriptureWords.HideWords(countWordsToHide);
    }

    public void DisplayWholeScripture()
    {
        _scriptureWords.ResetHiddenWords();
        Console.WriteLine(_reference.GetReferenceString());
        _scriptureWords.DisplayScriptureWords();
        Console.WriteLine();
    }




}