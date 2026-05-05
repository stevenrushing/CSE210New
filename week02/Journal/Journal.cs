public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
            Console.WriteLine();
        }
    }

    public void SaveToFile(string file)
    {
    using (StreamWriter outputFile = new StreamWriter(file))
    {
        foreach (Entry entry in _entries)
        {
            outputFile.WriteLine($"{entry._date}||{entry._promptText}||{entry._entryText}");  
        } 
    }
    }

    public void LoadFromFile (string file)
    {
        _entries.Clear();
        string filename = $"{file}";
        string[] entries = System.IO.File.ReadAllLines(filename);
        foreach (String line in entries)
        {
            string[] parts = line.Split("||");
            Entry newEntry = new Entry(parts[0], parts[1], parts[2]);
            _entries.Add(newEntry);
        }
    }
}