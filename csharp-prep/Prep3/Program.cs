using System;

class Program
{
    static void Main(string[] args)
    {
        string playAgain;

        do
        {

            int intGuess;
            string guess;
            int magicNumber;
            int count = 0;

            Random randomGenerator = new Random();
            magicNumber = randomGenerator.Next(1, 101);

            do
            {
                count ++;
                Console.Write("What is your guess: ");
                guess = Console.ReadLine();
                intGuess = int.Parse(guess);

                if (intGuess == magicNumber)
                {
                    Console.WriteLine($"You guessed it in this many guesses: {count}!");
                }
                else if (intGuess < magicNumber)
                {
                    Console.WriteLine("Higer");
                }
                else if (intGuess > magicNumber)
                {
                    Console.WriteLine("Lower");
                }

            } while (intGuess != magicNumber);


            Console.Write("Would you like to play again (y/n): ");
            playAgain = Console.ReadLine();

        } while (playAgain == "y");

        

            
    }
}