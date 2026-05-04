public class PromptGenerator
{
    public List<string> _prompts = new List<string>();

    public void LoadPrompts()
    {
        string[] linesRead = File.ReadAllLines("writing_prompts_short.txt");
        foreach (string item in linesRead)
        {
            _prompts.Add(item);
        }
    }

    public string GetRandomPrompt()
    {
        Random randomPrompt = new Random();
        int randomIndex = randomPrompt.Next(_prompts.Count);
        return _prompts[randomIndex];

    }

    public void ArchivePrompt(string prompt)
    {
        _prompts.Remove(prompt);
        SavePrompts();

    }

    public void SavePrompts()
    {
        File.WriteAllLines("writing_prompts_short.txt", _prompts);
    }
}