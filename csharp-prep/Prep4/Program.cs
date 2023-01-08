using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        string strNumber;
        int number;
        float sum = 0;
        int largest = 0;
        float average;
        List<int> numbers = new List<int>();

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        do
        {
            Console.Write("Enter number: ");
            strNumber = Console.ReadLine();
            number = int.Parse(strNumber);

            if (number != 0)
            {
                numbers.Add(number);
            }

        } while (number != 0);

        foreach (int i in numbers)
        {
            sum += i;

            if (i > largest)
            {
                largest = i;
            }
        }

        average = sum / numbers.Count;
        
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {largest}");

    }
}