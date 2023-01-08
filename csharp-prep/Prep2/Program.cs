using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Hello, please enter your grade percentage: ");
        string stringPercent = Console.ReadLine();
        int intPercent = int.Parse(stringPercent);

        string grade;
        bool pass = true;


        if (intPercent >= 90)
        {
            grade = "A";
        }
        else if (intPercent >= 80)
        {
            grade = "B";
        }
        else if (intPercent >= 70)
        {
            grade = "C";
        }
        else if (intPercent >= 60)
        {
            pass = false;
            grade = "D";
        }
        else
        {
            pass = false;
            grade = "F";
        }

        if (pass)
        {
            Console.WriteLine($"Congrats! you passed the class with a grade of {grade}({intPercent}%)!");
        }
        else
        {
            Console.WriteLine($"I'm sorry, a grade of {intPercent}%({grade}) is not passing. Keep trying! You'll get it!");
        }

    }
}