public class Reference
{
    private string _book;
    private int _chapter;
    private int _verse;
    private int _endVerse;
    public bool _wasGivenAnEndVerse;

    public Reference()
    {
        /* 
        To avoid "Compiler Error CS1729"
        3. Provide a parameterless (empty) constructor in the base class.
        https://bit.ly/3PEsPky
        */
    }

    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _wasGivenAnEndVerse = false;
    }

    public Reference(string book, int chapter, int startVerse, int endVerse)
    {   
        _book = book;
        _chapter = chapter;
        _verse = startVerse;
        _endVerse = endVerse;
        _wasGivenAnEndVerse = true;
    }

    public void SetReference(string book, int chapter, int startVerse)
    {
        _book = book;
        _chapter = chapter;
        _verse = startVerse;
    }

    public string GetReference()
    {
        return $"{_book} {_chapter}:{_verse}";
    }
    
    public string GetDisplayText()
    {   
        string output;

        if (_wasGivenAnEndVerse)
        {
            output = $"{_book} {_chapter}:{_verse}-{_endVerse}";
        }
        else
        {
            output = $"{_book} {_chapter}:{_verse}";
        }

        return output;
    }

    public override string ToString()
    {
        /* 
        Every C# class or structure implicitly inherits the Object class. 
        Therefore, every object in C# gets the ToString method, 
        which returns a string representation of that object.
        */
        string output;

        if (_wasGivenAnEndVerse)
        {
            output = $"{_book} {_chapter}:{_verse}-{_endVerse}";
        }
        else
        {
            output = $"{_book} {_chapter}:{_verse}";
        }

        return output;
    }

}