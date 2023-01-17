public class Journal 
{
    string _journalName;

    public string NameTheJournal()
    {
        Console.Write("Please name your journal. ");
        _journalName = Console.ReadLine();
        return _journalName;
    }
    public List<Entry> _entries = new List<Entry>();
    
    public void DisplayEntries()
    {
        
        foreach (Entry entry in _entries)
        {
            Console.WriteLine(entry._entry);
            Console.WriteLine();
        }
        
    }



}