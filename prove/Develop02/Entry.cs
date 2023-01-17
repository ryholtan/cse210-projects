public class Entry
{
    
    public string _entry;
    
    



    public void NewEntry()
    {
        DateTime _date = DateTime.Now;
        PromptGen prompt = new PromptGen();
        _entry = (string.Format("{0}  Prompt: {1}", _date, prompt.getPrompt()));
        Console.WriteLine(_entry);
        _entry += " " + Console.ReadLine();
    }

}