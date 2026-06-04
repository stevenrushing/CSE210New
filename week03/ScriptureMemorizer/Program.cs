// Exceeds - HideRandomWords only picks from words that haven't already been picked, this prevents wasting time on already hidden words, or mixing it up

using System;

class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference("John", 3, 16);
        Scripture scripture = new Scripture(reference,
            "For God so loved the world that he gave his only begotten Son " +
            "that whosoever believeth in him should not perish but have everlasting life");

        while (true)
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());

            if (scripture.IsCompletelyHidden())
            {
                Console.WriteLine("\nAll words are hidden, you're done!");
                break;
            }

            Console.Write("\nPress enter or type quit: ");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
                break;

            scripture.HideRandomWords(3);
        }
    }
}