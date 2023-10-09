using System;

class Program
{
    static void Main(string[] args)
    {
        int option = 0;

        while (option != 4)
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Start breathing activity");
            Console.WriteLine("  2. Start reflecting activity");
            Console.WriteLine("  3. Start listing activity");
            Console.WriteLine("  4. Quit");
            Console.Write("Select a choice from the menu: ");
            option = int.Parse(Console.ReadLine());
            
            if (option == 1)
            {
                BreathingActivity b = new BreathingActivity();    
                b.DisplayStartingMessage();
                Console.Clear();
                b.Run();
                
            }
            else if (option == 2)
            {
                ReflectingActivity r = new ReflectingActivity();
                r.DisplayStartingMessage();
                Console.Clear();
                r.Run();
            }
            else if (option == 3)
            {
                ListingActivity l = new ListingActivity();
                l.DisplayStartingMessage();
                Console.Clear();
                l.Run();
            }
            else
            {
                Console.WriteLine("\nThanks for using the Mindfulness Program.\n");
            }
        }
    }
}