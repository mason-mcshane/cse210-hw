public class Word

// Needs to be able to hide and show a word and check if it is hidden or not.
// Also needs a behavior to get the display text of said word(s).

{
    private string _text;
    private bool _isHidden;
    public Word(string text)
    {
        _text = text;
        _isHidden = true;
        _isHidden = false;
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
        int countChar = _text.Length;
        string underscores = new string('_', countChar);
        return _isHidden ? underscores : _text;
    }
}
