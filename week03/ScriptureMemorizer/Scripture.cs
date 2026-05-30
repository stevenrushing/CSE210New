public class Scripture
{
    private Reference _reference;
    private List<Word> _words = new List<Word>();

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        string[] textList = text.Split(' ');
        foreach (string word in textList)
        {
            _words.Add(new Word(word));
        }
    }

    public string GetDisplayText()
    {
        string words = "";
        foreach (Word word in _words)
        {
            words += word.GetDisplayText() + " ";
        }
        words = words.Trim();
        return $"{_reference.GetDisplayText()} {words}";
    }

    public void HideRandomWords(int numberToHide)
    {
        Random random = new Random();
        List<Word> visibleWords = new List<Word>();
        foreach (Word word in _words)
        {
            if (word.IsHidden() == false)
            {
                visibleWords.Add(word);
            }
        }

        int hideCount = numberToHide;
        if (visibleWords.Count < hideCount)
        {
            hideCount = visibleWords.Count;
        }

        for (int i = 0; i < hideCount; i++)
        {
            int index = random.Next(visibleWords.Count);
            visibleWords[index].Hide();
            visibleWords.RemoveAt(index);
        }
    }

    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (word.IsHidden() == false)
            {
                return false;
            }
        }
        return true;
    }

}