using System.IO;

public class FileHandler
{

    public string _defaultFile = "journal.txt";

    public void writeFile(List<Entry> entries)
    {
        string filename = promtpFileName($"What file would you like to save to ({_defaultFile}): ");
        using (StreamWriter outputfile = new StreamWriter(filename))
        {
            foreach (var entry in entries)
            {
                outputfile.WriteLine(entry.stringfy());
            }
        }
    }

    public string promtpFileName(string prompt)
    {
        Console.Write(prompt);
        string filename = Console.ReadLine();
        filename = filename == string.Empty ? _defaultFile : filename;
        return filename;
    }

    public List<Entry> readFile()
    {
        string filename = promtpFileName($"What file would you like to load({_defaultFile}): ");
        string[] lines = System.IO.File.ReadAllLines(filename);
        List<Entry> entries = new List<Entry>();
        foreach (string line in lines)
        {
            string[] parts = line.Split("|||");
            Entry e = new Entry();
            e.createFromList(parts);
            entries.Add(e);
        }
        return entries;
    }
}