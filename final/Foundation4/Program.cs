using System;

class Program
{
    static void Main(string[] args)
    {
        Running running = new Running(); 
        running.SetDate("03 Nov 2023");
        running.SetLength(1800); // 1800 seconds = 30 minutes
        running.SetSpeed(9.7);
        
        Cycling cycling = new Cycling();
        cycling.SetDate("05 Nov 2023");
        cycling.SetLength(3000); // 1800 seconds = 30 minutes
        cycling.SetDistance(10); 

        Cycling swimming = new Cycling();
        swimming.SetDate("05 Nov 2023");
        swimming.SetLength(3000); // 1800 seconds = 30 minutes
        swimming.SetLaps(6); 


        List<Activity> activities = new List<Activity>();
        activities.Add(running);
        activities.Add(cycling);
        activities.Add(swimming);

        foreach (Activity a in activities)
        {
            Console.WriteLine(a.GetSummary());
        }
    }
}