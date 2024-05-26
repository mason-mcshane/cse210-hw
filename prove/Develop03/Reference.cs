<<<<<<< HEAD
=======
using System.Text.RegularExpressions;

>>>>>>> 0620d7250d1158c260a3b0acf43850b83b16fdfd
public class Reference

// Needs to have the ability to get the display text of the reference
// which is a string the book, chapter, verse(s)

{
    private string _book;
    private int _chapter;
    private int _verse;
    private int _endVerse;

    public Reference (string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = verse;
    }
    public Reference (string book, int chapter, int startVerse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _verse = startVerse;
        _endVerse = endVerse;
    }
    
    public string GetBook()
    {
        return CleanString(_book);
    }
    public int GetChapter()
    {
        return _chapter;
    }
<<<<<<< HEAD
    public GetStartVerse()
    {
        return _verse;
    }
    public GetEndVerse()
=======
    public int GetStartVerse()
    {
        return _verse;
    }
    public int GetEndVerse()
>>>>>>> 0620d7250d1158c260a3b0acf43850b83b16fdfd
    {
        return _endVerse !=0 ? _endVerse : 0;
    }
    public string GetDisplayText()
    {
        if (_endVerse !=0 )
            return $"{_book} {_chapter}:{_verse}-{_endVerse}";
        else
            return $"{_book} {_chapter}:{_verse}";
    }
<<<<<<< HEAD
    static string CleanString(string input)
=======
    public string CleanString(string input)
>>>>>>> 0620d7250d1158c260a3b0acf43850b83b16fdfd
    {
        string cleaned = Regex.Replace(input, "[^a-zA-Z0-9]", "");

        string lowercase = cleaned.ToLower();

        return lowercase;
    }
}
