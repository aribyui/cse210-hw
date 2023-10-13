public class Word
{
    private string _text;
    private bool _isHidden;   

    public Word()
    {
        /* 
        Para evitar el error "Compiler Error CS1729"
        3. Proporcione un constructor sin parámetros en la clase base.
        https://bit.ly/3PEsPky
        */
    }
    public Word(string text)
    {
        _text = text;
        
        // La palabra es visible por defecto
        _isHidden = false;
    }

    public void Hide()
    {
        // La función 'Hide' no muestra nada.  
        // Es una función de tipo getter/setter.
       _isHidden = true;
    }

    public void Show()
    {
        // La función 'Show' no muestra nada.  
        // Es una función de tipo getter/setter.
        _isHidden = false;
    }

    public bool IsHidden()
    {
        return _isHidden;
    }

    public string GetDisplayText()
    {
        string output = "";

        if (_isHidden)
        {
            output = GetUnderscore(_text);
        }
        else
        {
            output = _text;
        }
        return output;
    }

    public string GetUnderscore(string word)
    {
        _text = word;
        
        string underScores = "";

        for (int i = 0; i < _text.Length; i++)
        {
            underScores += "_";
        }

        return underScores;
    }

}