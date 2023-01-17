using System.IO;

public class DataBase 
{
    public string _saveFile = "journal.txt";
    

    public void LoadFile()
    {
        string[] lines = System.IO.File.ReadAllLines(_saveFile);
        
        foreach (string line in lines)
        {
            Console.WriteLine(line);
            Console.WriteLine();
        }
        
    }

    public void SaveFile(List<Entry> entries)
    {
        Journal nameMe = new Journal();
        
        
        using (StreamWriter outputFile = File.AppendText(_saveFile))
        {
            outputFile.WriteLine(nameMe.NameTheJournal());
            foreach (Entry entry in entries)
            {
                outputFile.WriteLine(entry._entry);
            }
            
        }
    }
}