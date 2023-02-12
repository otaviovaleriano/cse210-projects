class Memorize
{
    private Scripture scripture;
    private Random random;

    public Memorize(Scripture scripture)
    {
        this.scripture = scripture;
        random = new Random();
    }

    public void Start()
    {
        
        // Console.WriteLine(GetDisplayText());
        while (true)
        {
            Console.Clear();
            Console.WriteLine(scripture.Reference);
            Console.WriteLine(GetDisplayText());
            Console.WriteLine("Press enter to continue or type 'quit' to finish: ");            
            string answer = Console.ReadLine();
            if (answer == "quit")
            {
                break;
            }

            HideRandomWords();
            // Console.Clear();
            // Console.WriteLine(scripture.Reference);
            // Console.WriteLine(GetDisplayText());
        }

    }

    private void HideRandomWords()
    {
        int count = random.Next(1, scripture.Words.Count);
        for (int i = 0; i < count; i++)
        {
            int index = random.Next(0, scripture.Words.Count);
            scripture.Words[index].Hidden = true;
        }
    }

    private string GetDisplayText()
    {
        string displayText = "";
        foreach (Word word in scripture.Words)
        {
            if (word.Hidden)
            {
                displayText += "_ ";
            }
            else
            {
                displayText += word.Text + " ";
            }
        }
        return displayText;
    }
}