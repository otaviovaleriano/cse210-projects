public class Entry
{

    // public List<string> _entries = new List<string>();
    public string _entry = "";
    public string _prompt = "";
    public string _date = "";


    public Entry()
    {
        _date = DateTime.Now.ToString("MM/dd/yyyy");
    }

    public void InsertEntry()
    {
        //  random for the option of prompts.
        // Random numGenerator = new Random();
        // int index = numGenerator.Next(4);
        // string randomQuestion = (_prompts[index]);
        // Console.Write(randomQuestion);
        _prompt = new Prompt().GeneratePrompts();
        Console.WriteLine(_prompt);
        // string answer = Console.ReadLine();
        _entry = Console.ReadLine();
        Console.Write("Saved!");
        // string wholeEntry = ($"{entryDate} - {_prompt} - {answer}");
        // _entries.Add(wholeEntry);
        // Console.WriteLine(_entries.Count());
        //the list is saving here, but replacing the last adition.
    }
    public void displayPrompt()
    {
        //solve the fact that the list _entries is not saving globally.
        // for (int i = 0; i < _entries.Count(); i++)
        // {
        //     Console.WriteLine(_entries[i]);
        // }
        Console.WriteLine($"{_date}: {_prompt}\n\t{_entry}");
    }

    public string stringfy()
    {
        return $"{_date} ||| {_prompt} ||| {_entry}";
    }

    public void createFromList(string[] entryDetails){
        _date=entryDetails[0];
        _prompt=entryDetails[1];
        _entry=entryDetails[2];
    }

}