using System;
using System.Xml.Serialization;

// Extra work - I added a feature to the prompt generator so that it deletes used prompts
// so you don't get the same prompt twice

class Program
{
    static void Main(string[] args)
    {
        Journal myJournal = new Journal();
        int userChoice = 0;
        while (userChoice != 5)
        {
            Console.WriteLine("Please select one of the following choices: ");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");
            userChoice = int.Parse(Console.ReadLine());

            if (userChoice == 1)
            {
                Entry entryObject = CreateEntry();
                myJournal.AddEntry(entryObject);
            }
            else if (userChoice == 2)
            {
                myJournal.DisplayAll();
            }
            else if (userChoice == 3)
            {
                Console.Write("Enter filename: ");
                string filename = Console.ReadLine();
                myJournal.LoadFromFile(filename);
            }
            else if (userChoice == 4)
            {
                Console.Write("Enter filename: ");
                string filename = Console.ReadLine();
                myJournal.SaveToFile(filename);
            }
            else if (userChoice == 5)
            {
                //pass?
            }
            else
            {
                Console.WriteLine("That was not a valid options. Please select a number from the menu. ");
            }
        }







    }
    static string RandomPrompt()
    {
        PromptGenerator test = new PromptGenerator();
        test.LoadPrompts();
        string prompt = test.GetRandomPrompt();
        test.ArchivePrompt(prompt);
        return prompt;
    }

    static Entry CreateEntry()
    {
        string randomPromptGenerated = RandomPrompt();
        Console.WriteLine(randomPromptGenerated);
        string currentDateTime = GetDateTime();
        string entry = WriteEntry();

        Entry newEntry = new Entry(currentDateTime, randomPromptGenerated, entry);
        return newEntry;
    }

    static string WriteEntry()
    {
        Console.Write("Please write your journal entry: ");
        string entryWritten = Console.ReadLine();
        return entryWritten;
    }
    
    static string GetDateTime()
    {
        DateTime currentDateTime = DateTime.Now;
        string formattedDateTime = currentDateTime.ToString("yyyy-MM-dd HH:mm");
        return formattedDateTime;
    }
}

// datetime code examples learned and adapted from: https://c-sharptutorial.com/datetime/datetime-in-csharp