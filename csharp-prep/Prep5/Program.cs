using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string userName = PromptUserName();
        int favNumber = PromptUserNumber();
        int squaredFavNumber = SquareNumber(favNumber);
        DisplayResult(userName, squaredFavNumber);

    }

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }

    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();

        return name;
    }

    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        string strNum = Console.ReadLine();
        int num = int.Parse(strNum);

        return num;
    }

    static int SquareNumber(int favNum)
    {
        int squared = favNum * favNum;

        return squared;
    }

    static void DisplayResult(string name, int sqNum)
    {
        Console.WriteLine($"{name}, the square of your number is {sqNum}");
    }
}