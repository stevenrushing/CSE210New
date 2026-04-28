using System;

class Program
{
    static void Main(string[] args)
    {
        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the Program!");
        }

        static string PromptUserName()
        {
            Console.Write("Please enter your name: ");
            string name = Console.ReadLine();
            return name;
        }

        static int PromptUserNumber()
        {
            Console.Write("Please enter your favorite number: ")
            int favNumber = int.Parse(Console.ReadLine());
            return favNumber;
        }

        static int SquareNumber(int numberToSquare)
        {
            return numberToSquare * numberToSquare;
        }

        static void DisplayResult(string name, int number)
        {
            Console.WriteLine($"{name}, the square of your number is {number}");
        }

        DisplayWelcome();
        string userName = PromptUserName();
        int num = PromptUserNumber();
        int squaredNum = SquareNumber(num);
        DisplayResult(userName, squaredNum);


    }
}