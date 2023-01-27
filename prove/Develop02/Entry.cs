public class Entry
{

    public List<string> _entries = new List<string>();
    public List<string> _prompts = new List<string>();
    DateTime _date = DateTime.Today;

    public Entry()
    {

    }

    public void GeneratePrompts()
    {
        _prompts.Add("What happened to you today?: ");
        _prompts.Add("Write a fun thing you did today: ");
        _prompts.Add("Write a sad that happened to you this week: ");
        _prompts.Add("Tell me a fun fact about you: ");
        _prompts.Add("What are you grateful for today?: ");
    }
    public void InsertEntry()
    {
        //  random for the option of prompts.
        Random numGenerator = new Random();
        int index = numGenerator.Next(4);
        string randomQuestion = (_prompts[index]);
        Console.Write(randomQuestion);
        string answer = Console.ReadLine();
        string entryDate = _date.ToString("MM/dd/yyyy");
        string wholeEntry = ($"{entryDate} - {randomQuestion} - {answer}");
        _entries.Add(wholeEntry);
        // the list is saving here, but replacing the last adition.
        // for (int i = 0; i < _entries.Count; i++)
        // {
        //     Console.WriteLine(_entries[i]);
        // } 
    }

    public void displayPrompt()
    {
        //solve the fact that the list _entries is not saving globally.
        for (int i = 0; i < _entries.Count; i++)
        {
            Console.WriteLine(_entries[i]);
        }
        Console.WriteLine("its working");
    }
}