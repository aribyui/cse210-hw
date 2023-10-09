public class ListingActivity : Activity
{
    int count = 0;
    private string _prompt = "";
    private List<string> _prompts = new List<string>();

    public ListingActivity()
    {
       _activityName = "Listing Activity" ;
       _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
    }

    public ListingActivity(string activityName, string description, int duration) : base(activityName, description, duration)
    {

    }

    public void Run()
    {
        GetReadyMessage();

        Console.WriteLine("List as many responses you can to the following prompt:");
        Console.WriteLine($"--{GetRandomPrompt()}--");
        Console.Write("You may begin in: ");
        ShowCountDown(1000);
        Console.WriteLine(); // line break

        List<string> items = new List<string>();
        
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            string inputUser = Console.ReadLine();
            items.Append(inputUser);
            count++;
        }

        Console.WriteLine($"You listed {count} items!");

        Console.WriteLine(); // line break

        DisplayEndingMessage();
    }

    public string GetRandomPrompt()
    {
        _prompts.Add("Who are people that you appreciate?");
        _prompts.Add("What are personal strengths of yours?");
        _prompts.Add("Who are people that you have helped this week?");
        _prompts.Add("When have you felt the Holy Ghost this month?");
        _prompts.Add("Who are some of your personal heroes?");

        Random rnd  = new Random();
        int rndIndx = rnd.Next(_prompts.Count);
        _prompt = _prompts[rndIndx];

        return _prompt;
    }
}