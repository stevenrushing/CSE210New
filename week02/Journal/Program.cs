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

        string randomPromptGenerated = RandomPrompt();
        Console.WriteLine(randomPromptGenerated);



    }
    static string RandomPrompt()
    {
        PromptGenerator test = new PromptGenerator();
        test.LoadPrompts();
        string prompt = test.GetRandomPrompt();
        test.ArchivePrompt(prompt);
        return prompt;
    }
}