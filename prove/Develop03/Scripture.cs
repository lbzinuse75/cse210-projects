using System.Diagnostics.Contracts;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.ComponentModel.DataAnnotations;

public class Scripture
{
    // Attributes
    private List<Word> _words;
    private Reference _reference;
    private string _text;
    private Random random = new Random();

    // Constructor - holds the reference, scripture text, and splits the scripture text into word objects in an array
    public Scripture(string text, Reference reference)
    {
        _reference = reference;
        _text = text;
        _words = new List<Word>();

        string[] wordArray = text.Split(" ");
        foreach(string word in wordArray)
        {
            Word wordObj = new Word(word);
            _words.Add(wordObj);
        }
    }

    // Displaying the scripture,
    public void Display()
    {
        Console.Write(_reference.GetReferenceString() + " ");

        foreach(Word word in _words)
        {
            Console.Write(word.GetWord() + " ");
        }

    }

    // Checking to see if the word is hidden
    public bool WordsHidden()
    {
        foreach(Word word in _words)
        {
            if(word.GetVisible())
                return false;
        }
        return true;
    }

    // Randomly selects a word within the _words list that is visible and hides it
    public void HideWord()
    {
        int index;

        do
        {
            index = random.Next(_words.Count);
        }while(!_words[index].GetVisible());

        _words[index].Hide();
    }
}