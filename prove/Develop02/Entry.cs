public class Entry
{   
    public string _date;
    public string _promptText;
    public string _entryText;
    public Prompts _promptGeneator = new Prompts();

    public void Display()
    {
        Console.WriteLine($"Date: {_date} - Prompt: {_promptText}");
        Console.WriteLine(_entryText);
    }
    public Entry() 
    {
        this._date = DateTime.Now.ToString("MM-dd-yyyy");
        _promptText = _promptGeneator.GenerateRandomPrompt();
        Console.WriteLine(_promptText);
        _entryText = Console.ReadLine();
    }
    public Entry(string date, string prompt, string entry)
    {
        this._date = date;
        _promptText = prompt;
        _entryText = entry;
    }
}   