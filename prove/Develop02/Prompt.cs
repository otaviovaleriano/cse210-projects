public class Prompt
{
    List<string> _prompts = new List<string>{

        "What happened to you today?: ",
        "Write a fun thing you did today: ",
        "Write a sad that happened to you this week:",
        "Tell me a fun fact about you: ",
        "What are you grateful for today?: "
    };

    public Prompt()
    {

    }

    public string GeneratePrompts()
    {
        Random random = new Random();
        return _prompts[random.Next(_prompts.Count)];
    }
}