using System;

class Program
{
    static void Main(string[] args)
    {
        MathAssignment math1 = new MathAssignment("Ryan", "Fractions", "8.5", "1-123");
        Console.WriteLine(math1.GetSummary());
        Console.WriteLine(math1.GetHomeworkList());

        WriteAssignment write1 = new WriteAssignment("Amy", "Euopean Dictators", "Hitler and the SS");
        Console.WriteLine(write1.GetSummary());
        Console.WriteLine(write1.GetWritingInfo());

    }
}