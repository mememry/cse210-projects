/*
    The Journal class contains a filename for storage of the journal and a list of entries.
    Methods include loading the journal from a file, saving the journal to a file, writing a new entry and displaying all entries.
    The filename is set to Journal.txt and is located in the same directory as the executable.
*/
public class Journal
{
    private string _fileName = "Journal.txt";
    public List<Entry> _entryList = new List<Entry>();
    PromptFile _promptList = new PromptFile();
    private Boolean _journalLoaded = false;
    public Boolean _journalSaved = false;



    /* Display the entire journal
    */
    public void DisplayJournal()
    {
        Console.WriteLine("Journal Entries:");

        foreach (Entry entry in _entryList)
        {
            entry.DisplayEntry();
            Console.WriteLine();
        }
    }

    /*
    The LoadJournal method reads the journal file and separates each line into date, prompt, and text, 
    appending each entry to _entryList. File format is expected to be "date|promptID|promptText|text".
    */
    public void LoadJournal()
    {
        string[] lines = System.IO.File.ReadAllLines(_fileName);

        foreach (string line in lines)
        {
            string[] parts = line.Split("|");

            string entryDate = parts[0];
            int promptID = int.Parse(parts[1]);
            string promptText = parts[2];
            string entryText = parts[3];

            Prompt entryPrompt = new Prompt { _promptID = promptID, _promptText = promptText };
            Entry newEntry = new Entry();
            newEntry.SaveEntry(entryDate, entryText, entryPrompt);
            _entryList.Add(newEntry);
        }
        _journalLoaded = true;
        Console.WriteLine("Journal loaded successfully.");
    }

    /*
    The SaveJournal method writes the _entryList to the journal file, formatting each entry as "date|promptID|promptText|text".
    */
    public void SaveJournal()
    {
        if (_journalLoaded)
        {
            using (StreamWriter journalFile = new StreamWriter(_fileName))
            {
                foreach (Entry entry in _entryList)
                {
                    string entryDate = entry._date;

                    string promptID = entry._prompt._promptID.ToString();
                    string promptText = entry._prompt._promptText;

                    string entryText = entry._text;
                    journalFile.WriteLine($"{entryDate}|{promptID}|{promptText}|{entryText}");
                }
                _journalSaved = true;
            }
        }
        else
        {
            Console.WriteLine("Journal not loaded. Would you like to save the journal with a new file name?");
            string newFileName = Console.ReadLine();
            if (!string.IsNullOrEmpty(newFileName))
            {
                _fileName = newFileName;
                SaveJournalWithNewNewFileName();
            }
            else
            {
                Console.WriteLine("No file name provided. Journal not saved.");
            }

        }
    }

    public void SaveJournalWithNewNewFileName()
    {
        using (StreamWriter journalFile = new StreamWriter(_fileName))
        {
            foreach (Entry entry in _entryList)
            {
                string entryDate = entry._date;

                string promptID = entry._prompt._promptID.ToString();
                string promptText = entry._prompt._promptText;

                string entryText = entry._text;
                journalFile.WriteLine($"{entryDate}|{promptID}|{promptText}|{entryText}");
            }
            _journalSaved = true;
        }
        Console.WriteLine($"Journal saved to {_fileName}.");
    }
    /*
    The WriteNewEntry method creates a new entry with the provided text, prompt, and adds the current date.
    */
    public void WriteNewEntryWithPrompt()
    {
        Prompt currentPrompt = new Prompt();
        Entry newEntry = new Entry();
        DateTime newEntryDate = DateTime.Now;
        string entryDate = newEntryDate.ToShortDateString();
        string entryText = "";

        _promptList.GetPromptList();
        currentPrompt = _promptList.GetRandomPrompt();

        Console.WriteLine(currentPrompt._promptText);
        entryText = Console.ReadLine();

        newEntry.SaveEntry(entryDate, entryText, currentPrompt);
        _entryList.Add(newEntry);
        _journalSaved = false; // Set to false since a new entry was added
    }

    // write a new entry without a prompt
    public void WriteNewEntryWithoutPrompt()
    {
        Prompt currentPrompt = new Prompt();
        Entry newEntry = new Entry();
        DateTime newEntryDate = DateTime.Now;
        string entryDate = newEntryDate.ToShortDateString();
        string entryText = "";
        currentPrompt._promptID = 0;
        currentPrompt._promptText = "User's Choice";

        Console.WriteLine("Please write your journal entry:");
        entryText = Console.ReadLine();

        newEntry.SaveEntry(entryDate, entryText, currentPrompt);
        _entryList.Add(newEntry);
        _journalSaved = false; // Set to false since a new entry was added
    }
}// End of Journal class
