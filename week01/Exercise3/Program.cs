using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise3 Project.");
        // string magicNum = "";
        // Console.Write("What is the magic number? ");
        // magicNum = Console.ReadLine();
        // int magicNumInt = int.Parse(magicNum);
        Random randomMagicNumber = new Random();
        int magicNumInt;
        int guessNumInt;
        int guessCounter = 0;
        string playGame = "yes";
        string guessCounterString;
        while (playGame == "yes")
        {
            magicNumInt = randomMagicNumber.Next(1,11);
            do
            {
                Console.Write("What is your guess? ");
                string guessNum = Console.ReadLine();
                guessNumInt = int.Parse(guessNum);
                guessCounter = guessCounter + 1;

                if (magicNumInt > guessNumInt)
                {
                    Console.WriteLine("Higher");
                }
                else if (magicNumInt < guessNumInt)
                {
                    Console.WriteLine("Lower");
                }
                else
                {
                    guessCounterString = guessCounter.ToString();
                    Console.WriteLine($"You guessed it in {guessCounterString} guesses!");
                }
            } while (!(magicNumInt == guessNumInt));   
            guessCounter = 0;
            Console.Write("Do you want to play again? ");
            playGame = Console.ReadLine();
        }


    }
}