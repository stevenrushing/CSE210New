public class PromptGenerator
{
    private List<string> _prompts = new List<string>();

    public void LoadPrompts()
    {
        string[] linesRead = File.ReadAllLines("writing_prompts.txt");
        foreach (string item in linesRead)
        {
            _prompts.Add(item);
        }
    }

    public string GetRandomPrompt()
    {
        Random randomGenerator = new Random();
        int randomIndex = randomGenerator.Next(_prompts.Count);
        return _prompts[randomIndex];

    }

    public void ArchivePrompt(string prompt)
    {
        _prompts.Remove(prompt);
        SavePrompts();

    }

    public void SavePrompts()
    {
        File.WriteAllLines("writing_prompts.txt", _prompts);
    }
}