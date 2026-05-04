using System;
using System.Xml.Serialization;

class Program
{
    static void Main(string[] args)
    {
        int userChoice = 0;
        // while (userChoice != 5)
        // {
        //     Console.WriteLine("Please select one of the following choices: ");
        //     Console.WriteLine("1. Write");
        //     Console.WriteLine("2. Display");
        //     Console.WriteLine("3. Load");
        //     Console.WriteLine("4. Save");
        //     Console.WriteLine("5. Quit");
        //     Console.Write("What would you like to do? ");
        //     userChoice = int.Parse(Console.ReadLine());
        // }

        PromptGenerator test = new PromptGenerator();
        test.LoadPrompts();

        Console.WriteLine("--- Before ---");
        foreach (string line in test._prompts)
        {
            Console.WriteLine(line);
        }

        string prompt = test.GetRandomPrompt();
        Console.WriteLine($"\nSelected: {prompt}");
        test.ArchivePrompt(prompt);

        Console.WriteLine("\n--- After ---");
        foreach (string line in test._prompts)
        {
            Console.WriteLine(line);
        }

    }
}