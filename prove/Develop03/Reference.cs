using System;
using System.IO;
using System.Runtime.CompilerServices;

public class Reference
{
    // attributes
    private string _bookName;
    private string _chapter;
    private string _verse;
    private string _endVerse;

    // constructor for a scripture with one verse
    public Reference(string bookName, string chapter, string verse)
    {
        _bookName = bookName;
        _chapter = chapter;
        _verse = verse;
        _endVerse = "";
    }
    // constructor for a scripture with more then one verse
    public Reference(string bookName, string chapter, string verse, string endVerse)
    {
        _bookName = bookName;
        _chapter = chapter;
        _verse = verse;
        _endVerse = endVerse;
    }

    // method for putting the reference together
    public string GetReferenceString()
    {
        if(_endVerse == "")
            return _bookName + " " + _chapter + ":" + _verse;
        else
            return _bookName + " " + _chapter + ":" + _verse + "-" + _endVerse;
    }

}