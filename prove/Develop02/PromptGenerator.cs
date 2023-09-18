public class PromptGenerator
{
    public List<string> _prompts = new List<string>();

    public void DisplayPrompts()
    {
        foreach(string p in _prompts)
        {
            Console.WriteLine(p);
        }
    }
}