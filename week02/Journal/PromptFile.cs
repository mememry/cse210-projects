/*
The PromptFile class handles reading prompts from a file and provides the method to get a random prompt.
The prompt file is named PromptFile.txt and is located in the same directory as the executable. 
The file contains an ID number and a prompt text separated by a pipe character (|).
*/
public class PromptFile
{
    private string _fileName = "PromptFile.txt";
    public List<Prompt> _promptList = new List<Prompt>();

    /*
    The GetPromptList method reads the4 prompt file and separates the line into the ID and text, 
    appending each line to _promptList.
    */
    public void GetPromptList()
    {
        string[] lines = System.IO.File.ReadAllLines(_fileName);
        int thisIDInt = 0;

        foreach (string line in lines)
        {
            string[] parts = line.Split("|");

            string thisID = parts[0];
            string thisText = parts[1];

            thisIDInt = int.Parse(thisID);
            _promptList.Add(new Prompt { _promptID = thisIDInt, _promptText = thisText });
        }
    }

    /*
    The GetRandomPrompt method returns a random prompt from the _promptList, using the Random class.
    */
    public Prompt GetRandomPrompt()
    {
        Random promptSelection = new Random();
        return _promptList[promptSelection.Next(_promptList.Count)];
    }
}// End of PromptFile class


