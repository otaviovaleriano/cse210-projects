using System;

class Program
{
    static void Main(string[] args)
    {
        //new object with the class Entry - to call methods.
        Entry p = new Entry();
        // generates one of the prompts.
        p.GeneratePrompts();
        p.InsertEntry();
        
    }
}