using System.IO;
public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry e)
    {
        _entries.Add(e);
    }

    public void DisplayEntries()
    {
        foreach (Entry e in _entries)
        {
            e.Display();
        }
    }
    
    public void LoadFromFile(Journal j)
    {
        Console.WriteLine("What is the filename? ");
        string fileName = Console.ReadLine();

        string[] lines = File.ReadAllLines(fileName);

        foreach (string line in lines)
        {
            string[] parts = line.Split("~");

            string date = parts[0];
            string prompt = parts[1];
            string input = parts[2];

            Entry e = new Entry();
            e._date = date;
            e._prompt = prompt;
            e._userInput = input;

            j.AddEntry(e);
        }
    }

    public void SaveToFile()
    {
        Console.WriteLine("What is the filename? ");
        string fileName = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            foreach (Entry e in _entries)
            {
                outputFile.WriteLine(e);
            }            
                               
            Console.WriteLine("The file was created.");
        }
    }
}