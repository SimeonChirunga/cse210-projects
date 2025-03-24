public class Scripture
{
    private string _book;
    private int _chapter;
    private int _startVerse;
    private int _endVerse;
    private List<Word> _words;
    private bool isMemorized;

    // Constructor for a single verse
    public Scripture(string book, int chapter, int verse, string text)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = verse;
        _endVerse = verse;
        _words = new List<Word>();
        string[] wordArray = text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        foreach (string word in wordArray)
        {
            _words.Add(new Word(word));
        }
        isMemorized = false;
    }

    // Constructor for a verse range
    public Scripture(string book, int chapter, int startVerse, int endVerse, string text)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = startVerse;
        _endVerse = endVerse;
        _words = new List<Word>();
        string[] wordArray = text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        foreach (string word in wordArray)
        {
            _words.Add(new Word(word));
        }
        isMemorized = false;
    }

    public string GetDisplayText()
    {
        string displayText = $"{_book} {_chapter}:{_startVerse}";
        if (_startVerse != _endVerse)
        {
            displayText += $"-{_endVerse}";
        }
        displayText += "\n";
        foreach (Word word in _words)
        {
            displayText += word.GetDisplayText() + " ";
        }
        return displayText.Trim();
    }

    public void HideRandomWords(Random random)
    {
        var visibleWords = _words.FindAll(w => !w.IsHidden());
        if (visibleWords.Count > 0)
        {
            int index = random.Next(visibleWords.Count);
            visibleWords[index].Hide();
        }
    }

    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }
        SetIsMemorized(true);
        return true;
    }

    public void RevealAllWords()
    {
        foreach (Word word in _words)
        {
            word.Show();
        }
    }

    public bool GetIsMemorized()
    {
        return isMemorized;
    }

    public void SetIsMemorized(bool value)
    {
        isMemorized = value;
    }
}
