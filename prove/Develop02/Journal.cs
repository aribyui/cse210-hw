using System.IO;
using Microsoft.VisualBasic.FileIO;
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
            string[] parts = line.Split(",");

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
                /*
                Tuve que implementar el método ToString() a la clase Entry,
                ya que al momento de guardar el achivo con cada una de las 
                entradas (entries), aparecían de la siguiente manera:

                Entry 
                Entry

                esto ocurría porque las entradas heredan de Object, y por eso
                devolvían el nombre de la clase (Entry), por esta razón no devolvía
                la representación de las entradas en formato de cadena o string. 
                */
                outputFile.WriteLine(e);
            }                                          
            Console.WriteLine("The file was created.");
        }
    }
}