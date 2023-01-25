public class Entry {

    public List<string> _entries = new List<string>();
    public List<string> _prompts = new List<string>();

    public Entry(){

    }

    public void GeneratePrompts(){
        _prompts.Add("What happened to you today?: ");
        _prompts.Add("Write a fun thing you did today: ");
        _prompts.Add("Write a sad that happened to you this week: ");
        _prompts.Add("Tell me a fun fact about you: ");
        _prompts.Add("What are you grateful for today?: ");
        // i need to make it random for the option of prompts.
        Console.WriteLine(_prompts[0]);
    }
    public void InsertEntry(){        
        // Console.Write("What happened to you today?");
        _entries.Add(Console.ReadLine());
        Console.WriteLine(_entries[0]);

        
    }



}