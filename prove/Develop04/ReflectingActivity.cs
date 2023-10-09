public class ReflectingActivity : Activity
{
    private string _prompt = "";
    private string _question = "";
    private List<string> _prompts = new List<string>();
    private List<string> _questions = new List<string>();

    public ReflectingActivity()
    {
        _activityName = "Reflecting Activity";
        _description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
    }

    public ReflectingActivity(string activityName, string description, int duration) : base(activityName, description, duration)
    {

    }
    
    public void Run()
    {        
        GetReadyMessage();
        
        Console.WriteLine("Consider the following prompt:\n");

        DisplayPrompt();
        Console.WriteLine();

        Console.WriteLine("When you have something in mind, press enter to continue."); 
        Console.ReadLine();

        Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");
        Console.Write("You may begin in: ");
        ShowCountDown(5);

        Console.Clear();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            DisplayQuestions();
            ShowSpinner(1000);
            Console.WriteLine(); // line break
        }

        Console.WriteLine(); // line break

        DisplayEndingMessage();
    }

    private string GetRandomPrompt()
    {
        _prompts.Add("Think of a time when you stood up for someone else.");
        _prompts.Add("Think of a time when you did something really difficult.");
        _prompts.Add("Think of a time when you helped someone in need.");
        _prompts.Add("Think of a time when you did something truly selfless.");

        Random rnd = new Random();
        int rndIndx = rnd.Next(_prompts.Count);
        _prompt = _prompts[rndIndx];

        return _prompt;
    }

    private string GetARandomQuestion()
    {
        _questions.Add("Why was this experience meaningful to you?");
        _questions.Add("Have you ever done anything like this before?");
        _questions.Add("How did you get started?");
        _questions.Add("How did you feel when it was complete?");
        _questions.Add("What made this time different than other times when you were not as successful?");
        _questions.Add("What is your favorite thing about this experience?");
        _questions.Add("What could you learn from this experience that applies to other situations?");
        _questions.Add("What did you learn about yourself through this experience?");
        _questions.Add("How can you keep this experience in mind in the future?");

        Random rnd = new Random();
        int rndInx = rnd.Next(_questions.Count);
        _question = _questions[rndInx];

        return _question;
    }

    public void DisplayPrompt()
    {
        Console.WriteLine($"--- {GetRandomPrompt()} ---");
    }

    public void DisplayQuestions()
    {
        Console.Write(GetARandomQuestion() + " "); // double quotation marks (" ") are a blank space after the random question
    }

}