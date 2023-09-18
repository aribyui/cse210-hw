using System;

class Program
{
    static void Main(string[] args)
    {
        PromptGenerator p = new PromptGenerator();
        p._prompts.Add("Who was the most interesting person I interacted with today?");
        p._prompts.Add("What was the best part of my day?");
        p._prompts.Add("How did I see the hand of the Lord in my life today?");
        p._prompts.Add("What was the strongest emotion I felt today?");
        p._prompts.Add("If I had one thing I could do over today, what would it be?");

        Entry entry;
        Journal journal1 = new Journal();
        Journal journal2 = new Journal();

        int option = 0;

        Console.WriteLine("\nWelcome to the Journal Program!");

        while (option != 5)
        {
            Console.WriteLine("Please select one of the following choices\n1. Write\n2. Display\n3. Load\n4. Save\n5. Quit");
            Console.Write("What would you like to do? ");
            option = int.Parse(Console.ReadLine());

            if (option == 1)
            {     
                Random r = new Random();
                int rndIndex = r.Next(p._prompts.Count);
                string randomPrompt = p._prompts[rndIndex];
                Console.WriteLine(randomPrompt);
                string userInput = Console.ReadLine();

                DateTime theCurrenTime = DateTime.Now;
                string dateText = theCurrenTime.ToShortDateString();

                entry = new Entry();
                entry._date = dateText;
                entry._prompt = randomPrompt;
                entry._userInput = userInput;

                journal1.AddEntry(entry);
                
                Console.WriteLine(); // blank space
            }
            else if (option == 2)
            {
               journal1.DisplayEntries();

               // Console.WriteLine(); // blank space
            }
            else if (option == 3)
            {
                journal2.LoadFromFile(journal1);

                Console.WriteLine(); // blank space
            }
            else if (option == 4)
            {
                journal1.SaveToFile();

                Console.WriteLine(); // blank space
            }
        }       
    }
}