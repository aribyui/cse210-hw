public class Activity
{
    protected string _activityName = "";
    protected string _description = "";
    protected int _duration = 0; 

    public Activity()
    {

    }

    public Activity(string activityName, string description, int duration)
    {
       _activityName = activityName;
       _description = description;
       _duration = duration;
    }

    public string GetActivityName()
    {
        return _activityName;
    }

    public void SetActivityName(string startMessage)
    {
        _activityName = startMessage;
    }

    public string GetDescription()
    {
        return _description;
    }

    public void SetDescription(string description)
    {
        _description = description;
    }

    public int GetDuration()
    {
        return _duration;
    }

    public void SetDuration(int duration)
    {
        _duration = duration;
    }

    public void DisplayStartingMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_activityName}\n");
        Console.WriteLine($"{_description}\n");
        Console.Write($"How long, in seconds, would you like your session? ");
        _duration = int.Parse(Console.ReadLine());
    }

    public void GetReadyMessage()
    {
        Console.WriteLine("Get ready...");
        ShowSpinner(1000); // 1000 = 1 seg
        Console.WriteLine(); // line break
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine("Well done!!");
        ShowSpinner(1000);
        Console.WriteLine($"\nYou have completed another {_duration} seconds of the {_activityName}");
        ShowSpinner(1000);
    }

    public void ShowSpinner(int seconds)
    {
        List<string> animationStrings = new List<string>();
        animationStrings.Add("|");
        animationStrings.Add("/");
        animationStrings.Add("-");
        animationStrings.Add("\\");
        animationStrings.Add("|");
        animationStrings.Add("/");
        animationStrings.Add("-");
        animationStrings.Add("\\");     

        foreach (string s in animationStrings)
        {
            Console.Write(s);
            Thread.Sleep(seconds);
            Console.Write("\b \b");
        }

    }

    public void ShowCountDown(int seconds)
    {
        for (int j = 5; j > 0; j--)
        {
            Console.Write(j);
            Thread.Sleep(seconds);
            Console.Write("\b \b");
        }        
    }
}