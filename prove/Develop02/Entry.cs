public class Entry
{
    public string _date;
    public string _prompt;
    public string _userInput;

    public void Display()
    {
        Console.WriteLine($"Date: {_date} - Prompt: {_prompt}\n{_userInput}\n");
    }

    public override string ToString()
    {
        return $"{_date}~{_prompt}~{_userInput}";     
    }    
}