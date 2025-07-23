
    /*
    The Entry class represents a single journal entry with the date, the prompt used, and the entry text.
    The methods will save an entry prompt, get the entry as a string, and display the entry.
    */
    public class Entry
    {
        public string _date;
        public string _text;
        public Prompt _prompt;

        /*
        the SaveEntry method stores the date, text, and prompt for the entry.
        Parameters are date, text, and prompt
        */
        public void SaveEntry(string entryDate, string entryText, Prompt entryPrompt)
        {
            _date = entryDate;
            _text = entryText;
            _prompt = entryPrompt;
        }

        /*
        The GetEntry method returns a string consisting of the date, prompt text, and entry text.
        */
        public string GetEntry()
        {
            return $"{_date} - {_prompt._promptText}: {_text}";
        }

        /*
        the DisplayEntry method displays the entry date, prompt text, and entry text on the console.
        */
        public void DisplayEntry()
        {
            Console.WriteLine(_date);
            if (_prompt != null)
            {
                Console.WriteLine($"Prompt: {_prompt._promptText}");
            }

            Console.WriteLine(_text);
        }
    }// End of Entry class

