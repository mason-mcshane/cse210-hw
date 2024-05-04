public class Journal
{
    private List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }

    public void SaveToFile()
    {
        Console.WriteLine("Enter file name");
        string fileName = Console.ReadLine();
        using (StreamWriter writer = new StreamWriter(fileName))
        {
            foreach (Entry entry in _entries)
            {
                string csvLine = $"{entry._date},{entry._promptText},{entry._entryText}";
                writer.WriteLine(csvLine);
            }
        }

        Console.WriteLine($"Entries saved to {fileName}");
    }

    public void LoadFromFile()
    {   
        Console.WriteLine("Enter file name");
        string fileName = Console.ReadLine();
        _entries.Clear();
        using (StreamReader reader = new StreamReader(fileName))
        {
            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine();

                if (!string.IsNullOrEmpty(line))
                {
                    string[] fields = line.Split(',');
                    Entry entry = new Entry(fields[0], fields[1], fields[2]);
                    _entries.Add(entry);
                }
            }
        }
        Console.WriteLine($"Entries loaded from {fileName}");
    }
 }

