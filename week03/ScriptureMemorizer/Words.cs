public class Words
{
    private List<string> _words = new List<string>();
    private List<bool> _hiddenWordIndexes = new List<bool>();

    public Words()
    {
        _words.Add("And");
        _words.Add("he");
        _words.Add("answered,");
        _words.Add("Fear");
        _words.Add("not:");
        _words.Add("for");
        _words.Add("they");
        _words.Add("that");
        _words.Add("be");
        _words.Add("with");
        _words.Add("us");
        _words.Add("are");
        _words.Add("more");
        _words.Add("than");
        _words.Add("they");
        _words.Add("that");
        _words.Add("be");
        _words.Add("with");
        _words.Add("them.");
        foreach (string word in _words)
        {
            _hiddenWordIndexes.Add(false);
        }
    }

    public Words(string word)
    {
        _words.Add(word);
    }

    public void DisplayScriptureWords()
    {
        for (int wordIndex = 0; wordIndex < _words.Count(); wordIndex++)
        {
            if (_hiddenWordIndexes[wordIndex])
            {
                for (int letterIndex = 0; letterIndex < _words[wordIndex].Length; letterIndex++)
                {
                    Console.Write("_");
                }
                Console.Write(" ");
            }
            else
            {
                Console.Write($"{_words[wordIndex]} ");
            }
        }
        foreach (string word in _words)
        {
            Console.Write($"{word.Length} ");
        }

    }

    public void HideWords(int wordsToHideCount)
    {
        if (_hiddenWordIndexes.Contains(false))
        {

            Random whichWordToHide = new Random();
            for (int i = 0; i < wordsToHideCount; i++)
            {
                int wordIndex = whichWordToHide.Next(0, _words.Count);
                while (_hiddenWordIndexes[wordIndex])
                {
                    if (wordIndex < _words.Count)
                    {
                        wordIndex++;
                    }
                    else
                    {
                        wordIndex = 0;
                    }
                }
                _hiddenWordIndexes[wordIndex] = true;
            }
        }
    }

    public int ScriptureWordCount()
    {
        return _words.Count;
    }

    public string GetWord(int wordIndex = 0)
    {
        if (wordIndex > 0 && wordIndex < _words.Count)
        {
            return _words[wordIndex];
        }
        else
        {
            return "";
        }
    }

    public void ResetHiddenWords()
    {
        _hiddenWordIndexes.Clear();
    }

    


}