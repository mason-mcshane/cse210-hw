public class Scripture

// The scripture class is mainly responsible for hiding the random words
// as well as getting the display text as a string.

// It should also have a behavior to check to see if the scripture
// is completely hidden so that it knows to end the program.

{
<<<<<<< HEAD
    private reference = _reference
    private List<Word> = _words

    public Scripture (Reference reference, string text)
    {
        _reference = reference
=======
    private Reference _reference;
    private List<Word> _words;

    public Scripture (Reference reference, string text)
    {
        _reference = reference;
>>>>>>> 0620d7250d1158c260a3b0acf43850b83b16fdfd
        _words = text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(word => new Word(word))
            .ToList();
    }
<<<<<<< HEAD
    public void HideRandomWords(int numberTohide)
    {
        List<int> remainingIndices = new List<int>();

        // Add indices of words that are not hidden
=======
    public void HideRandomWords(int numberToHide)
    {
        List<int> remainingIndices = new List<int>();
>>>>>>> 0620d7250d1158c260a3b0acf43850b83b16fdfd
        for (int i = 0; i < _words.Count; i++)
        {
            if (!_words[i].IsHidden())
            {
                remainingIndices.Add(i);
            }
        }
<<<<<<< HEAD

        Shuffle(remainingIndices);

=======
        remainingIndices = Shuffle(remainingIndices);
>>>>>>> 0620d7250d1158c260a3b0acf43850b83b16fdfd
        for (int i = 0; i < Math.Min(numberToHide, remainingIndices.Count); i++)
        {
            _words[remainingIndices[i]].Hide();
        }
    }
    public string GetDisplayText()
    {
        return string.Join(" ", _words.Select(word => word.GetDisplayText()));
    }
    public bool IsCompletetlyHidden()
    {
        return _words.All(word => word.IsHidden());
    }
<<<<<<< HEAD
=======
    private List<int> Shuffle(List<int> remainingIndices)
    {
        Random rnd = new Random();
        int n = remainingIndices.Count -1;
        while (n > 0)
        {
            int k = rnd.Next(n, remainingIndices.Count);
            n--;
            int temp = remainingIndices[n];
            remainingIndices[n] = remainingIndices[k];
            remainingIndices[k] = temp;
        }
        return remainingIndices;
    }
}