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
}