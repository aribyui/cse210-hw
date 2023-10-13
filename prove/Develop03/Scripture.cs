public class Scripture
{   
    private Reference _reference;
    private List<Word> _words = new List<Word>();
    private string _text; 
    string[] _splitWords; 

    public Scripture()
    {
        /* 
        Para evitar el error "Compiler Error CS1729"
        3. Proporcione un constructor sin parámetros en la clase base.
        https://bit.ly/3PEsPky
        */
    }

    public Scripture(Reference reference, string text)
    {        
        _reference = reference;
        _text = text;   

        _splitWords = _text.Split(" ");  

        foreach (string sub in _splitWords)
        {
            /*
            Se crea una instancia de la clase Word y
            se pasa como argumento al constructor de la clase Word.
            El iterador 'sub' por cada ciclo almacenará una variable de tipo string,
            la cuál, al pasarse como argumento al método constructor de la clase Word,
            devolverá un objeto de tipo 'Word' para que pueda ser interpretado 
            y agregado a la lista 'List<Word>'
            */
            Word _wrd = new Word(sub); 
            _words.Add(_wrd); 
        }

        /* 
        Este ciclo foreach se creo para comprobar si fue
        agregrada cada una de las palabras que conforman 
        el texto de la escritura a la lista 'List<word>'
        Se manda imprimir en consola.
        */
        // foreach (Word w in _words)
        // {
        //     Console.WriteLine(w.GetDisplayText()); 
        // }
    }

    public void HideRandomWords(int numberToHide) 
    {      
        // Se crea una instancia de la clase Random
        Random rnd = new Random(); 
        
        // Se genera un índice aleatorio dentro del rango del array _splitWords
        // Por ejemplo, el índice puede ser [0], [5] ó [7] según la longitud del texto de la escritura
        int rndIndx = rnd.Next(_splitWords.Length); 
        
        // Se obtiene una palabra aleatoria del array _splitWords
        string rndWord = _splitWords[rndIndx]; 
        
        // Se crea una instancia de la clase Word
        Word w = new Word(); 
        w.IsHidden();
        
        // Se asigna a la variable 'rndWord' la función 'GetUnderscore' que se encuentra en la clase Word
        // mediante la instancia 'w' creada anteriormente. 
        // Se usa este método para obtener la versión subrayada de la palabra aleatoria    
        rndWord = w.GetUnderscore(rndWord); 

        // Actualiza la palabra oculta en el array _splitWords.
        // Es decir, a la palabra aleatoria almacenada en la variable '_splitWords[rndIndx]'
        // se le asigna la variable 'rndWord', 
        // la cuál contiene la versión subrarada de la palabra aleatoria
        _splitWords[rndIndx] = rndWord; 

        // Actualiza el texto con las palabras ocultas
        _text = string.Join(" ", _splitWords); 
    }

    public bool IsCompleteHidden()
    {
        return true;
    }

    public string GetDisplayText()
    {   
        return $"{_reference} {_text}";
    }
}