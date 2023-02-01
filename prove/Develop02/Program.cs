using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

class Program
{
    static void Main(string[] args)
    {
        Entry p = new Entry();
        Journal j = new Journal();
        FileHandler file = new FileHandler();
        string message = string.Empty;
        Menu(p, j, file);

        void Menu(Entry p, Journal j, FileHandler file)
        {
            int choice = 0;
            // Console.Clear();
            Console.WriteLine("Please select one of the following choices: ");
            Console.WriteLine(" 1. Write \n 2. Display \n 3. Load \n 4. Save \n 5. Quit");
            choice = int.Parse(Console.ReadLine());
            if (choice == 5)
            {
                Console.Write("See yah!");
            }
            else
            {
                switch (choice)
                {
                    case 1:
                        // Console.WriteLine("option 1");
                        //new object with the class Entry - to call methods.
                        // generates one of the prompts.
                        message = j.addEntry();

                        // returns to menu after adding the entry.
                        Menu(p, j, file);

                        break;

                    case 2:
                        // Console.WriteLine("option 2");
                        j.displayEntry();
                        Menu(p, j, file);

                        break;

                    case 3:
                        // Console.WriteLine("option 3");
                        List<Entry> entries = file.readFile();
                        j.LoadEntries(entries);
                        message = "Loaded Entries Successfully";
                        Menu(p, j, file);

                        break;

                    case 4:
                        // Console.WriteLine("option 4");
                        file.writeFile(j.getEntries());
                        message = "Saved File Successfully";
                        Menu(p, j, file);
                        break;
                        
                    default:
                        //if a number other than 1-5 is entered, request
                        //player enter a number in that range
                        //wait for them to press enter, then call
                        //the menu again
                        Console.WriteLine("Please enter a number 1-5.");
                        Console.WriteLine("Press enter to continue...");
                        Console.ReadLine();
                        Menu(p, j, file);
                        break;
                }

            }

        }
    }
}