using System.Collections.Concurrent;

public class Word
{
    // Attributes
    private string _word;
    private string _hiddenWord = "";
    private bool _isTheWordVisible;

    // changes the visible words into hidden words
    public Word(string word)
    {
        _word = word;
        _isTheWordVisible = true;
        foreach(char letter in word)
        {
            _hiddenWord += "_";
        }
    }

    // boolean that return if the word is visible or not
    public bool GetVisible()
    {
        return _isTheWordVisible;
    }

    // tells if the word is hidden
    public void Hide()
    {
        _isTheWordVisible = false;
    }

    // tells if the word is visible
    public void Show()
    {
        _isTheWordVisible = true;
    }

    // if the word if visible return the wor if not return the hidden word
    public string GetWord()
    {
        if(_isTheWordVisible)
            return _word;
        else
            return _hiddenWord;
    }

}