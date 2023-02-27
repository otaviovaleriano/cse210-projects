using System;
using System.Threading;

class ReflectionActivity : Activity
{
    private string[] prompts = { "Think of a time when you stood up for someone else.", "Think of a time when you did something really difficult.", "Think of a time when you helped someone in need.", "Think of a time when you did something truly selfless." };
    private string[] questions = { "Why was this experience meaningful to you?", "Have you ever done anything like this before?", "How did you get started?", "How did you feel when it was complete?", "What made this time different than other times when you were not as successful?", "What is your favorite thing about this experience?", "What could you learn from this experience that applies to other situations?", "What did you learn about yourself through this experience?", "How can you keep this experience in mind in the future?" };

    public ReflectionActivity() : base("Reflection", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.") { }

    protected override void RunActivity()
    {
        int promptIndex = new Random().Next(prompts.Length);
        Console.WriteLine("Prompt: " + prompts[promptIndex]);
        Pause(5);
        foreach (string question in questions)
        {
            Console.Write(question + " ");
            // Spinner(3);
            Console.WriteLine();
            Pause(2);
        }
    }

    // private void Spinner(int v)
    // {
    //     int counter = 0;

    //     while (counter < v)
    //     {
    //         switch (counter % 4)
    //         {
    //             case 0: Console.Write("/"); break;
    //             case 1: Console.Write("-"); break;
    //             case 2: Console.Write("\\"); break;
    //             case 3: Console.Write("|"); break;
    //         }

    //         Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);

    //         Thread.Sleep(100);
    //         counter++;
    //     }

    //     Console.Write(" ");
    // }
}