
public class Word
{
    private string _text;
    private bool _isHidden;

    public Word(string text)
    {
        _text = text;
    }

    public void Hide()
    {
        _isHidden = true;
    }

    public void Show()
    {
        _isHidden = false;
    }

    public bool IsHidden()
    {
        return _isHidden;
    }

    public string GetDisplayText()
    {
        if (_isHidden == false)
        {
            return _text;
        }
        else
        {
            int iterator = 0;
            string blanks = "";
            while (iterator < _text.Length)
            {
                blanks += "_";
                iterator += 1;
            }
            return blanks;

        }
    }
}