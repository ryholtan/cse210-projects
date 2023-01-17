using System;

class Program
{
    static void Main(string[] args)
    {
        bool play = true;
        Journal journal = new Journal();
        

        Console.WriteLine("Welcome to the Journal Program!");
        do 
        {
            Console.WriteLine("Please select one of the following numbers: ");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");
            string _switch = Console.ReadLine();

            DataBase data = new DataBase();
            

            switch (_switch)
            {
                case "1":
                    Entry entry = new Entry();
                    entry.NewEntry();
                    journal._entries.Add(entry);
                    break;
                case "2":
                    journal.DisplayEntries();
                    Console.WriteLine();
                    break;
                case "3":
                    data.LoadFile();
                    break;
                case "4":
                    
                    data.SaveFile(journal._entries);
                    break;
                case "5":
                    play = false;
                    break;
                default:
                    Console.WriteLine("Press 5 to Quit or choose from list");
                    break;
                
            }
        } while (play);
            
    }
}