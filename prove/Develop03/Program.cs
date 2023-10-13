using System;

class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference("Nephi", 4, 3);

        Scripture scripture = new Scripture(reference, "And they had all things common among them; therefore there were not rich and poor, bond and free, but they were all made free, and partakers of the heavenly gift.");
        
        string answer = "";

        while (answer != "quit")
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("Press enter to continue or type 'quit' to finish: ");
            answer = Console.ReadLine();  
        
            if (answer != "quit")
            {
                scripture.HideRandomWords(1);        
            }                       
        }
        Console.WriteLine("\nThanks for using the Scripture Memorizer.\n");

        // // test
        // scripture.HideRandomWords(2);
    }
}