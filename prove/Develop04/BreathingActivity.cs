public class BreathingActivity : Activity
{
    public BreathingActivity()
    {
        _activityName = "Breathing Activity";
        _description = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
    }

    public BreathingActivity(string activityName, string description, int duration) : base (activityName, description, duration)
    {

    }
    
    public void Run() 
    {   
        GetReadyMessage();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {   
            /* 
            Necesito investigar un poco para descubrir cómo puedo
            agregar condicionales if else para que la actividad 
            comience solo cuando la cantidad de tiempo de la 
            actividad sea mayor o igual a 10 segundos.
            */
            Console.Write("Breathe in...");
            ShowCountDown(1000); // spinner spins 5 times

            Console.WriteLine(); // line break
            
            Console.Write("Breathe out...");        
            ShowCountDown(1000); // spinner spins 5 times

            Console.WriteLine(); // line break
            Console.WriteLine(); // line break
        } 
        DisplayEndingMessage();
    }
}